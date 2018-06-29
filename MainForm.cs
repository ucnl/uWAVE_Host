using System;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLNMEA;
using UCNLUI.Dialogs;

namespace uWAVE_Host
{
    public partial class MainForm : Form
    {
        #region Custom enums
       
        enum PortStateEnum
        {
            CLOSED,
            OPEN,
            ERROR,
            INVALID
        }

        #endregion

        #region Properties

        NMEASerialPort port;
        PrecisionTimer timer;

        SettingsProviderXML<SettingsContainer> settingsProvider;
        string settingsFileName;

        PortStateEnum portState = PortStateEnum.INVALID;
        PortStateEnum PortState
        {
            get
            {
                return portState;
            }
            set
            {
                portState = value;
                SetConnectionStateText(value.ToString());
            }
        }

        EventHandler timerTickHandler;
        EventHandler timerStartedHandler;

        EventHandler<NewNMEAMessageEventArgs> portNewNMEAMessageHandler;
        EventHandler<SerialErrorReceivedEventArgs> portPortErrorHandler;
        EventHandler<RawDataReceivedEventArgs> portRawDataHandler;

        bool isQuerying = false;
        bool IsQuerying
        {
            get
            {
                return isQuerying;
            }
            set
            {
                isQuerying = value;
                SetEnabledState(commandTableLayout, !value);
            }
        }

        string queryDescription = string.Empty;
        string queryResult = string.Empty;
        int targetTxID = -1;
        int ticks = 0;
        int timeoutTicks = 3;

        bool isRestart = false;

        Random rnd = new Random();

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();            

            #region settingsProvider

            settingsFileName = Path.ChangeExtension(Application.ExecutablePath, "settings");
            settingsProvider = new SettingsProviderXML<SettingsContainer>();
            settingsProvider.isSwallowExceptions = false;

            try
            {                
                settingsProvider.Load(settingsFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            #region NMEA

            //#define IC_D2H_ACK              '0'        // $PUWV0,cmdID,errCode
            //#define IC_H2D_SETTINGS_WRITE   '1'        // $PUWV1,rxChID,txChID
            //#define IC_H2D_RC_REQUEST       '2'        // $PUWV2,txChID,rcCmdID
            //#define IC_D2H_RC_RESPONSE      '3'        // $PUWV3,rcCmdID,propTime_seс,snr,[azimuth]
            //#define IC_D2H_RC_TIMEOUT       '4'        // $PUWV4,rcCmdID
            //#define IC_D2H_RC_ASYNC_IN      '5'        // $PUWV5,rcCmdID,snr,[azimuth]

            //#define IC_H2D_DINFO_GET        '?'        // $PUWV?,reserved
            //#define IC_D2H_DINFO            '!'        // $PUWV!,sys_moniker,sys_version,core_moniker [release],core_version,acBaudrate,rxChID,txChID,maxChannels

            NMEAParser.AddManufacturerToProprietarySentencesBase(ManufacturerCodes.UWV);
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "0", "x,x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "1", "x,x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "2", "x,x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "3", "x,x.x,x.x,x.x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "4", "x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "5", "x,x.x,x.x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "?", "x");
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "!", "c--c,x,c--c,x,x.x,x,x,x");

            #endregion

            #region port

            portNewNMEAMessageHandler = new EventHandler<NewNMEAMessageEventArgs>(port_NewNMEAMessage);
            portPortErrorHandler = new EventHandler<SerialErrorReceivedEventArgs>(port_PortError);
            portRawDataHandler = new EventHandler<RawDataReceivedEventArgs>(port_RawData);

            port = new NMEASerialPort(new SerialPortSettings(settingsProvider.Data.PortName, settingsProvider.Data.PortBaudrate,
                System.IO.Ports.Parity.None, DataBits.dataBits8, System.IO.Ports.StopBits.One, System.IO.Ports.Handshake.None));

            port.IsRawModeOnly = false;
            port.NewNMEAMessage += portNewNMEAMessageHandler;
            port.PortError += portPortErrorHandler;
            port.RawDataReceived += portRawDataHandler;

            #endregion

            #region timer

            timerTickHandler = new EventHandler(timer_Tick);
            timerStartedHandler = new EventHandler(timer_Started);

            timer = new PrecisionTimer();
            timer.Period = 1000;
            timer.Mode = Mode.Periodic;
            timer.Tick += timerTickHandler;
            timer.Started += timerStartedHandler;

            #endregion

            #region Other

            mainSplitContainer.Panel1.Enabled = false;
            commandPanel.Enabled = true;
            rawModePanel.Enabled = false;

            queryIDCbx.Items.AddRange(Enum.GetNames(typeof(RC_REQUEST_ID)));
            queryIDCbx.SelectedIndex = 0;

            string[] chIDs = new string[uWAVE.MaxChIDs];
            for (int i = 0; i < uWAVE.MaxChIDs; i++)
                chIDs[i] = i.ToString();

            settingsRxIDCbx.Items.AddRange(chIDs);
            settingsRxIDCbx.SelectedIndex = 0;
            settingsTxIDCbx.Items.AddRange(chIDs);
            settingsTxIDCbx.SelectedIndex = 0;
            targetRxIDCbx.Items.AddRange(chIDs);
            targetRxIDCbx.SelectedIndex = 0;

            #endregion
        }

        #endregion

        #region Methods        

        private void ExportToText(Control ctrl)
        {
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.Title = "Select file...";
                sDialog.Filter = "Plain text (*.txt)|*.txt";
                sDialog.DefaultExt = "txt";

                DateTime now = DateTime.Now;
                sDialog.FileName = string.Format("{0:00}-{1:00}-{2:00}_{3:00}-{4:00}-{5:00}.txt",
                    now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);

                if (sDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sDialog.FileName, ctrl.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void SetCtrlText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke((MethodInvoker)delegate { ctrl.Text = text; });
            ctrl.Text = text;
        }

        private void SetCbxItem(ComboBox cbx, string item)
        {
            int itemIdx = cbx.Items.IndexOf(item);
            if (itemIdx >= 0)
                cbx.SelectedIndex = itemIdx;
        }

        private void SetCbxSelectedItem(ComboBox cbx, string item)
        {
            if (cbx.InvokeRequired)
                cbx.Invoke((MethodInvoker)delegate { SetCbxItem(cbx, item); });
            else
                SetCbxItem(cbx, item);

        }
        

        private void Query_DINFO_GET()
        {
            if ((!IsQuerying) && (!timer.IsRunning))
            {

                if (TrySend(NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "?", new object[] { 0 })))
                {
                    IsQuerying = true;
                    timeoutTicks = 2;
                    timer.Start();
                    queryDescription = "? DINFO_GET...";
                    queryResult = string.Empty;

                    SetActionStateText(queryDescription);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void Query_SETTINGS_WRITE(int txID, int rxID)
        {
            if ((!IsQuerying) && (!timer.IsRunning))
            {
                if (TrySend(NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "1", new object[] { txID, rxID })))
                {
                    IsQuerying = true;
                    timeoutTicks = 5;
                    timer.Start();
                    queryDescription = "? SETTINGS_WRITE...";
                    queryResult = string.Empty;

                    SetActionStateText(queryDescription);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void Query_RC_REQUEST(int txID, RC_REQUEST_ID requestID)
        {
            if ((!IsQuerying) && (!timer.IsRunning))
            {
                if (TrySend(NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "2", new object[] { txID, requestID })))
                {
                    IsQuerying = true;
                    targetTxID = txID;
                    timeoutTicks = 2;
                    timer.Start();
                    queryDescription = string.Format("? SUB #{0}->{1}", txID, requestID);
                    queryResult = string.Empty;

                    SetActionStateText(queryDescription);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }


        #region Custom parsers

        private void Parse_ACK(object[] parameters)
        {
            LocalErrorID errCode = LocalErrorID.LOC_ERR_UNKNOWN;
            LOC_ACT_ID actID = LOC_ACT_ID.LAC_INVALID;

            try
            {
                actID = (LOC_ACT_ID)Enum.ToObject(typeof(LOC_ACT_ID), (int)parameters[0]);
                errCode = (LocalErrorID)Enum.ToObject(typeof(LocalErrorID), (int)parameters[1]);
            }
            catch
            {

            }

            if (errCode != LocalErrorID.LOC_ERR_UNKNOWN)
            {
                timer.Stop();
                IsQuerying = false;                
                queryResult = errCode.ToString();
                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));
            }
        }

        private void Parse_RC_RESPONSE(object[] parameters)
        {
            //$PUWV3,rcCmdID,propTime_seс,snr,[azimuth]

            RC_REQUEST_ID reqID = RC_REQUEST_ID.RC_INVALID;
            double propTime = double.NaN;
            double snr = double.NaN;
            double azimuth = double.NaN;

            try
            {
                reqID = (RC_REQUEST_ID)(int)parameters[0];
                propTime = (double)parameters[1];
                snr = (double)parameters[2];

                if (parameters[3] != null)
                    azimuth = (double)parameters[3];

                timer.Stop();
                IsQuerying = false;
                queryResult = "OK";
                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(">> RC_RESPONSE from SUB #{0} Cmd={1}, PropTime={2:F05} s, SNR={3:F01} dB", targetTxID, reqID, propTime, snr);
                if (!double.IsNaN(azimuth))
                    sb.AppendFormat(", Azimuth={0:F01}°", azimuth);
                sb.Append("\r\n");

                WriteHistoryLine(sb.ToString());
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("{0} in RC_RESPONSE sentence", ex.Message));
            }
        }

        private void Parse_RC_TIMEOUT(object[] parameters)
        {
            //$PUWV4,rcCmdID
            RC_REQUEST_ID reqID = RC_REQUEST_ID.RC_INVALID;
            
            try
            {
                reqID = (RC_REQUEST_ID)(int)parameters[0];
            
                timer.Stop();
                IsQuerying = false;
                queryResult = "REMOTE TIMEOUT";
                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));

                WriteHistoryLine(string.Format(">> RC_TIMEOUT from SUB #{0} Cmd={1}\r\n", targetTxID, reqID));
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("{0} in RC_TIMEOUT sentence", ex.Message));
            }
        }

        private void Parse_RC_ASYNC_IN(object[] parameters)
        {
            // $PUWV5,rcCmdID,snr,[azimuth]

            RC_REQUEST_ID reqID = RC_REQUEST_ID.RC_INVALID;            
            double snr = double.NaN;
            double azimuth = double.NaN;

            try
            {
                reqID = (RC_REQUEST_ID)(int)parameters[0];                
                snr = (double)parameters[1];

                if (parameters[2] != null)
                    azimuth = (double)parameters[2];

                timer.Stop();
                IsQuerying = false;
                queryResult = "OK";
                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(">> RC_ASYNC_IN Cmd={0}, SNR={1:F01} dB", reqID, snr);
                if (!double.IsNaN(azimuth))
                    sb.AppendFormat(", Azimuth={0:F01}°", azimuth);
                sb.Append("\r\n");

                WriteHistoryLine(sb.ToString());
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("{0} in RC_RESPONSE sentence", ex.Message));
            }
        }

        private void Parse_DINFO(object[] parameters)
        {
            // $PUWV!,sys_moniker,sys_version,core_moniker [release],core_version,acBaudrate,rxChID,txChID,maxChannels

            string sys_moniker = string.Empty;
            string sys_version = string.Empty;
            string core_moniker = string.Empty;
            string core_version = string.Empty;

            double acBaudrate = -1;
            int rxChID = -1;
            int txChID = -1;
            int maxChannels = -1;

            try
            {
                sys_moniker = parameters[0].ToString();
                sys_version = uWAVE.BCDVersionToStr((int)parameters[1]);
                core_moniker = parameters[2].ToString();
                core_version = uWAVE.BCDVersionToStr((int)parameters[3]);
                acBaudrate = (double)parameters[4];
                rxChID = (int)parameters[5];
                txChID = (int)parameters[6];
                maxChannels = (int)parameters[7];

                timer.Stop();
                IsQuerying = false;
                queryResult = "OK";
                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));

                SetCtrlText(systemLbl, string.Format("{0} v{1}", sys_moniker, sys_version));
                SetCtrlText(coreLbl, string.Format("{0} v{1}", core_moniker, core_version));
                SetCtrlText(totalChannelsLbl, maxChannels.ToString());
                SetCtrlText(acBaudrateLbl, string.Format("{0:F02} bit/s", acBaudrate));

                SetCbxSelectedItem(settingsRxIDCbx, rxChID.ToString());
                SetCbxSelectedItem(settingsTxIDCbx, txChID.ToString());                
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("{0} in D_INFO sentence", ex.Message));
            }
        }

        #endregion


        private bool TrySend(string message)
        {
            bool result = false;
            try
            {
                port.SendData(message);
                WriteHistoryLine(string.Format("<< {0}", message));
                result = true;
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("ERROR: ", ex.Message));
            }

            return result;
        }

        private void WriteHistoryLine(string text)
        {
            DateTime dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0:00}:{1:00}:{2:00}.{3:000}: {4}",
                dt.Hour, dt.Minute, dt.Second, dt.Millisecond, text);

            if (!text.EndsWith("\r\n"))
                sb.AppendFormat("\r\n");

            WriteHistory(sb.ToString());
        }

        private void WriteRawHistoryLine(string text)
        {
            DateTime dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0:00}:{1:00}:{2:00}.{3:000}: {4}",
                dt.Hour, dt.Minute, dt.Second, dt.Millisecond, text);

            if (!text.EndsWith("\r\n"))
                sb.AppendFormat("\r\n");

            if (rawModeHistoryTxb.InvokeRequired)
                rawModeHistoryTxb.Invoke((MethodInvoker)delegate { rawModeHistoryTxb.AppendText(sb.ToString()); });
            else
                rawModeHistoryTxb.AppendText(sb.ToString());
        }

        private void WriteHistory(string text)
        {
            if (historyTxb.InvokeRequired)
                historyTxb.Invoke((MethodInvoker)delegate { historyTxb.AppendText(text); });
            else
                historyTxb.AppendText(text);
        }

        private void SetConnectionStateText(string text)
        {
            if (mainStatusStrip.InvokeRequired)
                mainStatusStrip.Invoke((MethodInvoker)delegate { connectionStateLbl.Text = text; });
            else
                connectionStateLbl.Text = text;
        }

        private void SetActionStateText(string text)
        {
            if (mainStatusStrip.InvokeRequired)
                mainStatusStrip.Invoke((MethodInvoker)delegate { actionLbl.Text = text; });
            else
                actionLbl.Text = text;
        }

        private void SetEnabledState(Control ctrl, bool state)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke((MethodInvoker)delegate { ctrl.Enabled = state; });
            else
                ctrl.Enabled = state;
        }

        private string GetRandomString(int length)
        {
            byte[] bytes = new byte[length / 2];
            rnd.NextBytes(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
                sb.AppendFormat("{0:X2}", bytes[i]);

            return sb.ToString();
        }

        #endregion

        #region Handlers

        #region timer

        private void timer_Started(object sender, EventArgs e)
        {
            ticks = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (++ticks >= timeoutTicks)
            {
                IsQuerying = false;
                queryResult = "timeout";
                timer.Stop();

                SetActionStateText(string.Format("{0} ...{1}", queryDescription, queryResult));
            }
        }

        #endregion

        #region port

        private void port_NewNMEAMessage(object sender, NewNMEAMessageEventArgs e)
        {
            if (PortState != PortStateEnum.OPEN)
                PortState = PortStateEnum.OPEN;

            WriteHistoryLine(string.Format(">> {0}", e.Message));

            bool isParsed = true;
            NMEASentence pResult = null;
            try
            {
                pResult = NMEAParser.Parse(e.Message);
                isParsed = true;
            }
            catch (Exception ex)
            {
                WriteHistoryLine(string.Format("ERROR: {0}", ex.Message));
            }
            

            if ((isParsed) && (pResult is NMEAProprietarySentence))
            {
                NMEAProprietarySentence pSentence = (pResult as NMEAProprietarySentence);

                if (pSentence.Manufacturer == ManufacturerCodes.UWV)
                {
                    if (pSentence.SentenceIDString == "0") // ACK
                    {
                        Parse_ACK(pSentence.parameters);
                    }
                    else if (pSentence.SentenceIDString == "3") // RC_RESPONSE
                    {
                        Parse_RC_RESPONSE(pSentence.parameters);
                    }
                    else if (pSentence.SentenceIDString == "4") // RC_TIMEOUT
                    {
                        Parse_RC_TIMEOUT(pSentence.parameters);
                    }
                    else if (pSentence.SentenceIDString == "5") // RC_ASYNC_IN
                    {
                        Parse_RC_ASYNC_IN(pSentence.parameters);
                    }
                    else if (pSentence.SentenceIDString == "!") // DINFO
                    {
                        Parse_DINFO(pSentence.parameters);
                    }
                    else
                    {
                        // unsupported sentence
                    }
                }
                else
                {
                    // unsupported manufacturer
                }
            }
        }

        private void port_PortError(object sender, EventArgs e)
        {
            PortState = PortStateEnum.ERROR;
        }

        private void port_RawData(object sender, RawDataReceivedEventArgs e)
        {
            if (port.IsRawModeOnly)
            {
                WriteRawHistoryLine(string.Format(">> {0}\r\n", Encoding.ASCII.GetString(e.Data)));
            }
        }

        #endregion

        #region Controls

        #region historyTxb

        private void historyTxb_TextChanged(object sender, EventArgs e)
        {
            if (historyTxb.Text.Length >= historyTxb.MaxLength - 1024)
                historyTxb.Clear();

            historyTxb.ScrollToCaret();            
        }

        #endregion

        #region historyTxbToolStrip

        private void historyCopyToClipboardBtn_Click(object sender, EventArgs e)
        {
            historyTxb.SelectAll();
            historyTxb.Copy();
            historyTxb.DeselectAll();
        }

        private void toPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToText(historyTxb);
        }

        private void historyClearBtn_Click(object sender, EventArgs e)
        {
            historyTxb.Clear();
        }

        #endregion

        #region mainToolStrip

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Close();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PortState = PortStateEnum.CLOSED;
                connectBtn.Text = "Connect";
                connectBtn.Checked = false;
                settingsBtn.Enabled = true;
                mainSplitContainer.Panel1.Enabled = false;          
            }
            else
            {
                try
                {
                    port.Open();
                    PortState = PortStateEnum.OPEN;
                    connectBtn.Text = "Disconnect";
                    connectBtn.Checked = true;
                    settingsBtn.Enabled = false;
                    mainSplitContainer.Panel1.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            bool isSaved = false;

            using (SettingsEditor sEditor = new SettingsEditor())
            {
                sEditor.Value = settingsProvider.Data;

                if (sEditor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    settingsProvider.Data = sEditor.Value;                    

                    try
                    {
                        settingsProvider.Save(settingsFileName);
                        isSaved = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if ((isSaved) && (MessageBox.Show("Settings saved. Restart application to apply new settings?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
            {
                isRestart = true;
                Application.Restart();
            }
        }

        private void isRawModeOnlyBtn_Click(object sender, EventArgs e)
        {
            port.IsRawModeOnly = !port.IsRawModeOnly;
            isRawModeOnlyBtn.Checked = port.IsRawModeOnly;
            commandPanel.Enabled = !port.IsRawModeOnly;
            rawModePanel.Enabled = port.IsRawModeOnly;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            using (AboutBox aDialog = new AboutBox())
            {
                aDialog.ApplyAssembly(Assembly.GetExecutingAssembly());
                aDialog.Weblink = "www.unavlab.com";
                aDialog.ShowDialog();
            }
        }

        #endregion

        #region commandPanel

        private void devInfoGetLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Query_DINFO_GET();
        }

        private void settingsApplyLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int txID = int.Parse(settingsTxIDCbx.SelectedItem.ToString());
            int rxID = int.Parse(settingsRxIDCbx.SelectedItem.ToString());
            Query_SETTINGS_WRITE(txID, rxID);
        }

        private void remoteQueryLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int txID = int.Parse(targetRxIDCbx.SelectedItem.ToString());
            RC_REQUEST_ID requestID = (RC_REQUEST_ID)Enum.Parse(typeof(RC_REQUEST_ID), queryIDCbx.SelectedItem.ToString());
            Query_RC_REQUEST(txID, requestID);
        }

        #endregion

        #region rawDataPanel

        private void rawModeHistoryTxb_TextChanged(object sender, EventArgs e)
        {
            rawModeHistoryTxb.ScrollToCaret();
        }

        private void rawDataSendBtn_Click(object sender, EventArgs e)
        {
            var message = Encoding.ASCII.GetBytes(rawDataInputTxb.Text);

            try
            {
                port.SendRaw(message);
                WriteRawHistoryLine(string.Format("<< {0}\r\n", rawDataInputTxb.Text));
                rawDataInputTxb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rawDataInputTxb_TextChanged(object sender, EventArgs e)
        {
            rawDataSendBtn.Enabled = !string.IsNullOrEmpty(rawDataInputTxb.Text);
        }

        private void rawHistoryCopyToClipboardBtn_Click(object sender, EventArgs e)
        {
            rawModeHistoryTxb.SelectAll();
            rawModeHistoryTxb.Copy();
            rawModeHistoryTxb.DeselectAll();
        }

        private void rawHistoryExportToPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToText(rawModeHistoryTxb);
        }

        private void rawHistoryClearBtn_Click(object sender, EventArgs e)
        {
            rawModeHistoryTxb.Clear();
        }

        private void generateDatetimeStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            rawDataInputTxb.Text = string.Format("*uWAVE TEST {0:00}-{1:00}-{2:0000}, {3:00}:{4:00}:{5:00}.{6:000}*",
                dt.Day, dt.Month, dt.Year, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        private void randomString16BytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawDataInputTxb.Text = GetRandomString(16);       
        }

        private void randomString32BytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawDataInputTxb.Text = GetRandomString(32);
        }

        #endregion

        #region mainForm

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            port.NewNMEAMessage -= portNewNMEAMessageHandler;
            port.PortError -= portPortErrorHandler;
            port.RawDataReceived -= portRawDataHandler;
            if (port.IsOpen)
            {
                try
                {
                    port.Close();
                }
                catch
                {
                }
            }

            port.Dispose();

            timer.Tick -= timerTickHandler;
            timer.Started -= timerStartedHandler;
            if (timer.IsRunning) 
                timer.Stop();

            timer.Dispose();
        }

        #endregion                                                        
        
        #endregion                        

        #endregion                
    }
}
