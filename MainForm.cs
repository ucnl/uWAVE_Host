﻿using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLUI.Dialogs;
using uWAVELib;

namespace uWAVE_Host
{
    public partial class MainForm : Form
    {      
        #region Properties

        TSLogProvider logger;
        string loggerFileName;

        uWAVEPort port;
        
        SimpleSettingsProviderXML<SettingsContainer> settingsProvider;
        string settingsFileName;

        Random rnd = new Random();

        double pressure_mBar = UCNLPhysics.PHX.PHX_ATM_PRESSURE_MBAR;
        double temperature_C = 0;
        double soundSpeed = UCNLPhysics.PHX.PHX_FWTR_SOUND_SPEED_MPS;

        bool isRCAutoQuery
        {
            get { return rcAutoChb.Checked; }
            set { rcAutoChb.Checked = value; }
        }

        RC_Statistics rcStatistics;

        RC_CODES_Enum[] autoQueryCodes = new RC_CODES_Enum[] 
        { 
            RC_CODES_Enum.RC_DPT_GET, RC_CODES_Enum.RC_TMP_GET, RC_CODES_Enum.RC_BAT_V_GET 
        };
        int autoQueryIdx = 0;

        #region UI items

        string deviceInfoTxt
        {
            get { return deviceInfoTxb.Text; }
            set { deviceInfoTxb.Text = value; }
        }

        int txChannelID
        {
            get { return txChIDCbx.SelectedIndex; }
            set 
            {
                if (value <= txChIDCbx.Items.Count)
                    txChIDCbx.SelectedIndex = value;
            }
        }

        int rxChannelID
        {
            get { return rxChIDCbx.SelectedIndex; }
            set
            {
                if (value <= rxChIDCbx.Items.Count)
                    rxChIDCbx.SelectedIndex = value;
            }

        }

        double salinityPSU
        {
            get { return Convert.ToDouble(salinityEdit.Value); }
            set
            {
                decimal vl = Convert.ToDecimal(value);
                if (vl > salinityEdit.Maximum) vl = salinityEdit.Maximum;
                if (vl < salinityEdit.Minimum) vl = salinityEdit.Minimum;
                salinityEdit.Value = vl;
            }
        }

        double gravityAcc
        {
            get { return Convert.ToDouble(gravityAccEdit.Value); }
            set
            {
                decimal vl = Convert.ToDecimal(value);
                if (vl > gravityAccEdit.Maximum) vl = gravityAccEdit.Maximum;
                if (vl < gravityAccEdit.Minimum) vl = gravityAccEdit.Minimum;
                gravityAccEdit.Value = vl;
            }
        }

        bool isCommandModeByDefault
        {
            get { return isCommandModeByDefaultChb.Checked; }
            set { isCommandModeByDefaultChb.Checked = value; }
        }

        bool isACKOnTXFinished
        {
            get { return isACKOnTXFinishedChb.Checked; }
            set { isACKOnTXFinishedChb.Checked = value; }
        }



        bool isAMBSaveToFlash
        {
            get { return isAMBSaveSettingsToFlashChb.Checked; }
            set { isAMBSaveSettingsToFlashChb.Checked = value; }

        }

        bool isAMBPressure
        {
            get { return isAMBPressureChb.Checked; }
            set { isAMBPressureChb.Checked = value; }
        }

        bool isAMBTemperature
        {
            get { return isAMBTemperatureChb.Checked; }
            set { isAMBTemperatureChb.Checked = value; }
        }

        bool isAMBDepth
        {
            get { return isAMBDepthChb.Checked; }
            set { isAMBDepthChb.Checked = value; }
        }

        bool isAMBVoltage
        {
            get { return isAMBVoltageChb.Checked; }
            set { isAMBVoltageChb.Checked = value; }
        }

        int AMBPeriod
        {
            get { return Convert.ToInt32(AMBUpdatePeriodEdit.Value); }
            set
            {
                Decimal vl = value;
                if (vl > AMBUpdatePeriodEdit.Maximum) vl = AMBUpdatePeriodEdit.Maximum;
                if (vl < AMBUpdatePeriodEdit.Minimum) vl = AMBUpdatePeriodEdit.Minimum;
                AMBUpdatePeriodEdit.Value = vl;
            }
        }


        bool isPTCROLSaveToFlash
        {
            get { return isPtcRolSaveToFlashChb.Checked; }
            set { isPtcRolSaveToFlashChb.Checked = value; }
        }

        int PTCROLPeriod
        {
            get { return Convert.ToInt32(PtcRolUpdatePeriodEdit.Value); }
            set
            {
                Decimal vl = value;
                if (vl > PtcRolUpdatePeriodEdit.Maximum) vl = PtcRolUpdatePeriodEdit.Maximum;
                if (vl < PtcRolUpdatePeriodEdit.Minimum) vl = PtcRolUpdatePeriodEdit.Minimum;
                PtcRolUpdatePeriodEdit.Value = vl;
            }
        }



        int rcTxChannelID
        {
            get
            {
                return rcTargetTxChIDCbx.SelectedIndex;
            }
            set
            {
                if (value <= rcTargetTxChIDCbx.Items.Count)
                    rcTargetTxChIDCbx.SelectedIndex = value;
            }
        }

        int rcRxChannelID
        {
            get
            {
                return rcTargetRxChIDCbx.SelectedIndex;
            }
            set
            {
                if (value <= rcTargetRxChIDCbx.Items.Count)
                    rcTargetRxChIDCbx.SelectedIndex = value;
            }
        }

        RC_CODES_Enum rcQueryID
        {
            get
            {
                return (RC_CODES_Enum)Enum.Parse(typeof(RC_CODES_Enum), rcQueryIdCbx.SelectedItem.ToString());
            }
            set
            {
                int idx = rcQueryIdCbx.Items.IndexOf(value.ToString());
                if (idx >= 0)
                    rcQueryIdCbx.SelectedIndex = idx;
            }
        }


        bool isPtEnabled
        {
            get { return isPtModeChb.Checked; }
            set { isPtModeChb.Checked = value; }
        }

        byte ptLocalAddress
        {
            get { return Convert.ToByte(ptLocalAddressEdit.Value); }
            set { ptLocalAddressEdit.Value = value; }
        }

        bool isPtSaveToFlash
        {
            get { return ptIsSaveToFlashChb.Checked; }
            set { ptIsSaveToFlashChb.Checked = value; }
        }

        byte ptTargetAddress
        {
            get { return Convert.ToByte(ptTargetAddressEdit.Value); }
            set { ptTargetAddressEdit.Value = value; }
        }

        byte ptMaxTries
        {
            get { return Convert.ToByte(ptTriesEdit.Value); }
            set { ptTriesEdit.Value = value; }
        }


        byte ptQueryTargetAddress
        {
            get { return Convert.ToByte(ptQueryAddressEdit.Value); }
            set { ptQueryAddressEdit.Value = value; }
        }

        DataID ptQueryDataID
        {
            get
            {
                return (DataID)Enum.Parse(typeof(DataID), ptQueryDataIDCbx.SelectedItem.ToString());
            }
            set
            {
                int idx = ptQueryDataIDCbx.Items.IndexOf(value.ToString());
                if (idx >= 0)
                    rcQueryIdCbx.SelectedIndex = idx;
            }
        }


        #endregion

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            #region Misc.

            this.Text = Assembly.GetExecutingAssembly().GetName().Name;           

            #endregion

            #region logger
            
            loggerFileName = StrUtils.GetTimeDirTreeFileName(DateTime.Now, Application.ExecutablePath, "LOG", "log", true);           
            logger = new TSLogProvider(loggerFileName);
            logger.TextAddedEvent += (o, e) => { InvokeAppendLine(historyTxb, e.Text); };
            logger.WriteStart();
                        
            #endregion
            
            #region settingsProvider

            settingsFileName = Path.ChangeExtension(Application.ExecutablePath, "settings");
            settingsProvider = new SimpleSettingsProviderXML<SettingsContainer>();
            settingsProvider.isSwallowExceptions = false;

            try
            {
                settingsProvider.Load(settingsFileName);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }

            logger.Write(settingsProvider.Data.ToString());

            #endregion

            #region port

            port = new uWAVEPort(settingsProvider.Data.PortName, settingsProvider.Data.PortBaudrate);

            port.ACKReceived += new EventHandler<ACKReceivedEventArgs>(port_ACKReceived);
            port.AMBDataReceived += new EventHandler(port_AMBDataReceived);
            port.DeviceInfoReceived += new EventHandler(port_DeviceInfoReceived);
            port.DeviceTimeout += new EventHandler<DeviceTimeoutEventArgs>(port_DeviceTimeout);            
            port.RawDataReceived += new EventHandler<RawDataReceivedEventArgs>(port_RawDataReceived);
            port.RCAsyncInReceived += new EventHandler<RCAsyncInReceivedEventArgs>(port_RCAsyncInReceived);
            port.RCResponseReceived += new EventHandler<RCResponseReceivedEventArgs>(port_RCResponseReceived);
            port.RCTimeoutReceived += new EventHandler<RCTimeoutReceivedEventArgs>(port_RCTimeoutReceived);
            
            port.InfoEvent += (o, e) => { logger.Write(string.Format("{0}: {1}", e.EventType, e.LogString)); };
            port.PortError += (o, e) => { logger.Write(string.Format("{0} in {1}", e.EventType.ToString(), settingsProvider.Data.PortName)); };
            port.UnknownSentenceReceived += (o, e) => { logger.Write(string.Format(" >> Unknown sentence: {0}", e.Sentence)); };

            port.PacketModeSettingsReceived += (o, e) =>
                {
                    InvokeOnTransactionEnd();

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            isPtEnabled = port.IsPacketMode;
                            ptLocalAddress = port.PacketMode_Address;
                        });
                    }
                    else
                    {
                        isPtEnabled = port.IsPacketMode;
                        ptLocalAddress = port.PacketMode_Address;
                    }
                };

            port.PacketTransferFailed += (o, e) =>
                {
                    var line = string.Format("Failed to deliver packet \"{0}\" to address {1}, {2} tries taken\r\n",
                        Encoding.ASCII.GetString(e.DataPacket), e.Target_ptAddress, e.TriesTaken);

                    InvokeAppendLine(ptHistoryTxb, line);

                    logger.Write(line);
                };

            port.PacketTransferred += (o, e) =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Delivered packet \"{0}\" to address {1}, {2} tries taken.",
                        Encoding.ASCII.GetString(e.DataPacket), e.Target_ptAddress, e.TriesTaken);

                    if (!double.IsNaN(e.Azimuth))
                        sb.AppendFormat(CultureInfo.InvariantCulture, " Azimuth {0:F01}°", e.Azimuth);

                    sb.AppendLine();

                    InvokeAppendLine(ptHistoryTxb, sb.ToString());
                    logger.Write(sb.ToString());
                };

            port.PacketReceived += (o, e) =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Received packet \"{0}\" from address {1}",
                        Encoding.ASCII.GetString(e.DataPacket), e.Target_ptAddress);

                    if (!double.IsNaN(e.Azimuth))
                        sb.AppendFormat(CultureInfo.InvariantCulture, " Azimuth {0:F01}°", e.Azimuth);

                    sb.AppendLine();

                    InvokeAppendLine(ptHistoryTxb, sb.ToString());
                    logger.Write(sb.ToString());
                };

            port.PacketResponse += (o, e) =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("#{0} >> {1}={2:F03}", e.Target_ptAddress, e.DataId.ToString(), e.DataValue);

                    if (!double.IsNaN(e.PropagationTime_s))
                        sb.AppendFormat(CultureInfo.InvariantCulture, ", Prop. time={0:F05} sec.", e.PropagationTime_s);

                    if (!double.IsNaN(e.Azimuth))
                        sb.AppendFormat(CultureInfo.InvariantCulture, ", Azimuth {0:F01}°", e.Azimuth);

                    sb.AppendLine();

                    InvokeAppendLine(ptQueryHistoryTxb, sb.ToString());
                    logger.Write(sb.ToString());
                };

            port.PacketRequestTimeout += (o, e) =>
                {
                    var str = string.Format("#{0} >> Timeout caused by {1} query!\r\n", e.Target_ptAddress, e.DataId.ToString());
                    InvokeAppendLine(ptQueryHistoryTxb, str);
                    logger.Write(str);
                };

            port.PTCROLLDataReceived += (o, e) =>
                {
                    StringBuilder sb = new StringBuilder();

                    if (!double.IsNaN(port.Pitch))
                        sb.AppendFormat(CultureInfo.InvariantCulture, "PITCH: {0:F01} °\r\n", port.Pitch);

                    if (!double.IsNaN(port.Roll))
                        sb.AppendFormat(CultureInfo.InvariantCulture, "ROLL: {0:F01} °\r\n", port.Roll);

                    InvokeSetText(ptcRolTxb, sb.ToString());
                };

            #endregion

            #region Misc.
            
            isCommandModeByDefault = false;

            for (int i = 0; i < uWAVE.CR_STRONG_MAX_CODE_CHANNELS; i++)
            {
                txChIDCbx.Items.Add(i);
                rxChIDCbx.Items.Add(i);
                rcTargetTxChIDCbx.Items.Add(i);
                rcTargetRxChIDCbx.Items.Add(i);
            }

            txChannelID = 0;
            rxChannelID = 0;
            rcTxChannelID = 0;
            rcRxChannelID = 0;

            rcQueryIdCbx.Items.AddRange(new string[] 
            { 
                RC_CODES_Enum.RC_PING.ToString(),
                RC_CODES_Enum.RC_DPT_GET.ToString(),
                RC_CODES_Enum.RC_TMP_GET.ToString(),
                RC_CODES_Enum.RC_BAT_V_GET.ToString(),
                RC_CODES_Enum.RC_USR_CMD_000.ToString(),
                RC_CODES_Enum.RC_USR_CMD_001.ToString(),
                RC_CODES_Enum.RC_USR_CMD_002.ToString(),
                RC_CODES_Enum.RC_USR_CMD_003.ToString(),
                RC_CODES_Enum.RC_USR_CMD_004.ToString(),
                RC_CODES_Enum.RC_USR_CMD_005.ToString(),
                RC_CODES_Enum.RC_USR_CMD_006.ToString(),
                RC_CODES_Enum.RC_USR_CMD_007.ToString(),
                RC_CODES_Enum.RC_USR_CMD_008.ToString()
            });

            rcQueryID = RC_CODES_Enum.RC_PING;

            cmdModePnl.Enabled = false;
            rawModePnl.Enabled = false;

            rcStatistics = new RC_Statistics();
            rcStatistics.InitStatValue("DST, m", "F03");
            rcStatistics.InitStatValue("MSR, dB", "F01");
            rcStatistics.InitStatValue("BAT, V", "F01");
            rcStatistics.InitStatValue("DPT, m", "F01");
            rcStatistics.InitStatValue("TMP, °C", "F01");

            ptQueryDataIDCbx.Items.Clear();
            ptQueryDataIDCbx.Items.AddRange(new string[] 
            {
                DataID.DPT.ToString(),
                DataID.TMP.ToString(),
                DataID.BAT.ToString()
            });

            ptQueryDataIDCbx.SelectedIndex = 0;

            #endregion
        }

        #endregion

        #region Methods

        private void InvokeSetText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke((MethodInvoker)delegate { ctrl.Text = text; });
            else
                ctrl.Text = text;
        }
        
        private void SaveText(string text)
        {
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.Title = "Exporting to a text file...";
                sDialog.Filter = "Plain text (*.txt)|*.txt";
                sDialog.DefaultExt = "txt";

                if (sDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sDialog.FileName, text);
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, true);
                    }
                }
            }

        }

        private void InvokeAppendLine(RichTextBox txb, string line)
        {
            if (txb.InvokeRequired)
                txb.Invoke((MethodInvoker)delegate { AppendLine(txb, line); });
            else
                AppendLine(txb, line);
        }

        private void AppendLine(RichTextBox txb, string line)
        {
            txb.AppendText(line);
            if (!line.EndsWith("\r\n"))
                txb.AppendText("\r\n");
        }

        private void ProcessException(Exception ex, bool isMsgBox)
        {
            logger.Write(ex);

            if (isMsgBox)
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnPortOpen()
        {
            settingsBtn.Enabled = false;            
            commandModeSwitchBtn.Enabled = true;
            connectBtn.Checked = true;
            connectBtn.Text = "DISCONNECT";
            logger.Write(string.Format("{0} opened", settingsProvider.Data.PortName));
            cmdModePnl.Enabled = port.IsCommandMode;
            rawModePnl.Enabled = !port.IsCommandMode;
        }

        private void OnPortClose()
        {
            settingsBtn.Enabled = true;
            commandModeSwitchBtn.Enabled = false;
            connectBtn.Checked = false;
            connectBtn.Text = "CONNECT";
            logger.Write(string.Format("{0} closed", settingsProvider.Data.PortName));
            cmdModePnl.Enabled = false;
            rawModePnl.Enabled = false;
        }

        private void OnTransactionStart()
        {
            cmdModePnl.Enabled = false;
            rawModePnl.Enabled = false;
        }

        private void OnTransactionEnd()
        {
            cmdModePnl.Enabled = port.IsCommandMode;
            rawModePnl.Enabled = !port.IsCommandMode;            
        }

        private void InvokeOnTransactionEnd()
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { OnTransactionEnd(); });
            else
                OnTransactionEnd();
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

        private string ByteArrayToHexStr(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }

            return sb.ToString();
        }

        private void PerformRCRequest()
        {
            if (isRCAutoQuery)
            {
                autoQueryIdx = (autoQueryIdx + 1) % autoQueryCodes.Length;
                RC_CODES_Enum queryID = autoQueryCodes[autoQueryIdx];

                Thread.Sleep(500);

                if (port.RCRequestQuery(rcRxChannelID, rcTxChannelID, queryID))
                    OnTransactionStart();
            }
        }

        private void InvokePerformRCRequest()
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { PerformRCRequest(); });
            else
                PerformRCRequest();
        }

        private void ShowRCStatistics()
        {
            rcTxb.Text = rcStatistics.ToString();
        }

        private void InvokeShowRCStatistics()
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { ShowRCStatistics(); });
            else
                ShowRCStatistics();
        }

        #endregion

        #region Handlers

        #region port

        private void port_ACKReceived(object sender, ACKReceivedEventArgs e)
        {
            InvokeOnTransactionEnd();    
            if (e.SentenceID != ICs.IC_D2H_ANY)
                logger.Write(string.Format("HINT: ACK for sentence \"{0}\", result={1}", e.SentenceID, e.ErrorID));
            else
                logger.Write(string.Format("HINT: ACK result={0}", e.ErrorID));
        }

        private void port_AMBDataReceived(object sender, EventArgs e)
        {
            bool isReCalcSoundSpeed = false;
            StringBuilder sb = new StringBuilder();
            if (!double.IsNaN(port.Pressure_mBar))
            {
                sb.AppendFormat(CultureInfo.InvariantCulture, "PRESSURE: {0:F02} mBar\r\n", port.Pressure_mBar);
                pressure_mBar = port.Pressure_mBar;
                isReCalcSoundSpeed = true;
            }

            if (!double.IsNaN(port.Temperature_C))
            {
                sb.AppendFormat(CultureInfo.InvariantCulture, "TEMPERATURE: {0:F01}°C\r\n", port.Temperature_C);
                temperature_C = port.Temperature_C;
                isReCalcSoundSpeed = true;
            }

            if (!double.IsNaN(port.Depth_m))
                sb.AppendFormat(CultureInfo.InvariantCulture, "DEPTH: {0:F03} m\r\n", port.Depth_m);

            if (!double.IsNaN(port.SupplyVoltage_V))
                sb.AppendFormat(CultureInfo.InvariantCulture, "SUPPLY VOLTAGE: {0:F01} V\r\n", port.SupplyVoltage_V);

            if (isReCalcSoundSpeed)
                soundSpeed = soundSpeed = UCNLPhysics.PHX.Speed_of_sound_UNESCO_calc(temperature_C, pressure_mBar, salinityPSU);

            sb.AppendFormat(CultureInfo.InvariantCulture, "SOUND SPEED: {0:F01} m/s\r\n", soundSpeed);

            InvokeSetText(ambTxb, sb.ToString());
        }

        private void port_DeviceInfoReceived(object sender, EventArgs e)
        {
            InvokeOnTransactionEnd();

            if (port.IsDeviceInfo)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    deviceInfoTxt = string.Format(CultureInfo.InvariantCulture, "SYSTEM: {0} v{1}\r\nCORE: {2} v{3}\r\nSERIAL: {4}\r\nACOUSTIC BAUDRATE: {5:F02} bps\r\nTOTAL POSSIBLE CODE CHANNELS: {6}\r\nPTS PRESENT: {7}\r\n",
                    port.SystemMoniker, port.SystemVersion,
                    port.CoreMoniker, port.CoreVersion,
                    port.SerialNumber,
                    port.AcousticBaudrate,
                    port.TotalCodeChannels,
                    port.IsPTS);

                    rxChannelID = port.RxChID;
                    txChannelID = port.TxChID;

                    salinityPSU = port.SalinityPSU;

                    isCommandModeByDefault = port.IsCommandModeByDefault;

                    soundSpeed = UCNLPhysics.PHX.Speed_of_sound_UNESCO_calc(temperature_C, pressure_mBar, salinityPSU);
                });
            }
        }

        private void port_DeviceTimeout(object sender, DeviceTimeoutEventArgs e)
        {
            InvokeOnTransactionEnd();

            if (e.SentenceID != ICs.IC_D2H_ANY)
                logger.Write(string.Format("HINT: device timeout (after sentence \"{0}\")", e.SentenceID));
            else
                logger.Write("HINT: device timeout");
        }        

        private void port_RawDataReceived(object sender, RawDataReceivedEventArgs e)
        {
            var sToLog = string.Format("[RAW] >> {0}", Encoding.ASCII.GetString(e.Data));
            InvokeAppendLine(rawHistoryTxb, string.Format(" >> {0}", Encoding.ASCII.GetString(e.Data)));
            logger.Write(sToLog);                       
        }

        private void port_RCAsyncInReceived(object sender, RCAsyncInReceivedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(CultureInfo.InvariantCulture, "HINT: RC_ASYNC_IN Cmd={0}, SNR={1:F01} dB", e.RCCmdID, e.SNR_db);
            if (e.IsAzimuthPresent)
                sb.AppendFormat(CultureInfo.InvariantCulture, ", Azimuth={0:F00}°", e.Azimuth);
            sb.Append("\r\n");

            logger.Write(sb.ToString());

        }

        private void port_RCResponseReceived(object sender, RCResponseReceivedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(CultureInfo.InvariantCulture, "HINT: RC_RESPONSE from SUB #{0} Cmd={1}, PropTime={2:F05} s, SNR={3:F01} dB\r\n", e.TxChID, e.RCCmdID, e.PropTime_sec, e.SNR_db);
            sb.AppendFormat(CultureInfo.InvariantCulture, "HINT: Slant range is {0:F03} (Sound speed = {1:F02})\r\n", e.PropTime_sec * soundSpeed, soundSpeed);

            if (e.IsValuePresent)
                sb.AppendFormat(CultureInfo.InvariantCulture, "HINT: Value={0:F01} ({1})\r\n", e.Value, e.RCCmdID);

            if (e.IsAzimuthPresent)
                sb.AppendFormat(CultureInfo.InvariantCulture, "HINT: Azimuth={0:F00}°\r\n", e.Azimuth);

            logger.Write(sb.ToString());

            rcStatistics.AddSuccess();
            rcStatistics.AddMeasurement("DST, m", e.PropTime_sec * soundSpeed);
            rcStatistics.AddMeasurement("MSR, dB", e.SNR_db);

            if (e.RCCmdID == RC_CODES_Enum.RC_BAT_V_GET)
            {
                rcStatistics.AddMeasurement("BAT, V", e.Value);
            }
            else if (e.RCCmdID == RC_CODES_Enum.RC_DPT_GET)
            {
                rcStatistics.AddMeasurement("DPT, m", e.Value);
            }
            else if (e.RCCmdID == RC_CODES_Enum.RC_TMP_GET)
            {
                rcStatistics.AddMeasurement("TMP, °C", e.Value);
            }

            InvokeShowRCStatistics();
            InvokePerformRCRequest();
        }

        private void port_RCTimeoutReceived(object sender, RCTimeoutReceivedEventArgs e)
        {
            logger.Write(string.Format(CultureInfo.InvariantCulture, "HINT: RC_TIMEOUT from SUB #{0}, Cmd={1}", e.TxChID, e.RCCmdID));

            rcStatistics.AddFail();
            InvokeShowRCStatistics();
            InvokePerformRCRequest();
        }      

        #endregion

        #region UI

        #region common

        private void richTxb_TextChanged(object sender, EventArgs e)
        {
            (sender as RichTextBox).ScrollToCaret();
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
                    ProcessException(ex, true);
                }

                OnPortClose();
            }
            else
            {
                try
                {
                    port.Open();
                    OnPortOpen();
                }
                catch (Exception ex)
                {
                    ProcessException(ex, true);
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
                Application.Restart();
            }
        }


        private void commandModeSwitchBtn_Click(object sender, EventArgs e)
        {
            port.IsCommandMode = !port.IsCommandMode;
            commandModeSwitchBtn.Checked = port.IsCommandMode;

            cmdModePnl.Enabled = port.IsCommandMode;
            rawModePnl.Enabled = !port.IsCommandMode;

            if (!port.IsCommandMode)
                isRCAutoQuery = false;
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
        
        #region rawModeToolStrip

        private void rawClearBtn_Click(object sender, EventArgs e)
        {
            rawHistoryTxb.Clear();
        }

        private void rawExportBtn_Click(object sender, EventArgs e)
        {
            SaveText(rawHistoryTxb.Text);
        }

        private void rawCopyBtn_Click(object sender, EventArgs e)
        {
            rawHistoryTxb.Copy();
            MessageBox.Show("History copied to clipboard");
        }

        #endregion              

        #region histToolStrip

        private void histClearBtn_Click(object sender, EventArgs e)
        {
            historyTxb.Clear();
        }
        
        private void histExportBtn_Click(object sender, EventArgs e)
        {
            SaveText(historyTxb.Text);
        }

        private void histCopyBtn_Click(object sender, EventArgs e)
        {
            historyTxb.Copy();
        }

        private void historyTxb_TextChanged(object sender, EventArgs e)
        {
            historyTxb.ScrollToCaret();
        }

        #endregion
        
        #region deviceInfo tab

        private void devSettingsQueryBtn_Click(object sender, EventArgs e)
        {
            if (port.DeviceInfoQuery())
                OnTransactionStart();
        }

        private void devSettingsApplyBtn_Click(object sender, EventArgs e)
        {
            if (port.SettingsWriteQuery(txChannelID, rxChannelID, salinityPSU, isCommandModeByDefault, isACKOnTXFinished, gravityAcc))
                OnTransactionStart();
        }

        #endregion

        #region Ambient settings tab

        private void AMBSetBtn_Click(object sender, EventArgs e)
        {
            if (port.AMBDTAConfigQuery(isAMBSaveToFlash, AMBPeriod, isAMBPressure, isAMBTemperature, isAMBDepth, isAMBVoltage))
                OnTransactionStart();
        }

        private void ptcRolSetBtn_Click(object sender, EventArgs e)
        {
            if (port.PTCROLLConfigQuery(isPTCROLSaveToFlash, PTCROLPeriod))
                OnTransactionStart();
        }

        #endregion

        #region remote query tab

        private void rcQueryBtn_Click(object sender, EventArgs e)
        {
            if (port.RCRequestQuery(rcRxChannelID, rcTxChannelID, rcQueryID))
                OnTransactionStart();
        }

        private void rcAutoChb_CheckedChanged(object sender, EventArgs e)
        {
            rcQueryBtn.Enabled = !isRCAutoQuery;
            ptSendBtn.Enabled = !isRCAutoQuery;
            ptApplySettingsBtn.Enabled = !isRCAutoQuery;
            devSettingsApplyBtn.Enabled = !isRCAutoQuery;
            rcTargetRxChIDCbx.Enabled = !isRCAutoQuery;
            rcTargetTxChIDCbx.Enabled = !isRCAutoQuery;
            rcQueryIdCbx.Enabled = !isRCAutoQuery;

            if (isRCAutoQuery)
            {
                rcQueryBtn_Click(null, null);
            }
        }

        private void rcClearStatsBtn_Click(object sender, EventArgs e)
        {
            rcTxb.Clear();
            rcStatistics.Clear();
        }        

        #endregion

        #region packet mode tab

        private void ptQuerySettingsBtn_Click(object sender, EventArgs e)
        {
            if (port.PacketMode_SettingQuery())
                OnTransactionStart();
        }

        private void ptApplySettingsBtn_Click(object sender, EventArgs e)
        {
            if (port.PacketMode_SettingsWrite(isPtSaveToFlash, isPtEnabled, ptLocalAddress))
                OnTransactionStart();
        }

        private void ptSendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ptToSendTxb.Text))
            {
                if (port.PacketMode_AbortSend())
                {
                    OnTransactionStart();
                }
            }
            else
            {
                if (port.PacketMode_Send(ptTargetAddress, ptMaxTries, Encoding.ASCII.GetBytes(ptToSendTxb.Text)))
                {
                    ptToSendTxb.Clear();
                    OnTransactionStart();
                }
            }
        }

        private void isPtModeChb_CheckedChanged(object sender, EventArgs e)
        {
            ptSendBtn.Enabled = isPtEnabled;
        }

        private void ptClearTxbBtn_Click(object sender, EventArgs e)
        {
            ptHistoryTxb.Clear();
        }
        

        private void ptSend8ByteStrBtn_Click(object sender, EventArgs e)
        {
            ptToSendTxb.Text = GetRandomString(8);
        }

        private void ptSend32ByteStrBtn_Click(object sender, EventArgs e)
        {
            ptToSendTxb.Text = GetRandomString(32);
        }

        private void ptSend16ByteStrBtn_Click(object sender, EventArgs e)
        {
            ptToSendTxb.Text = GetRandomString(16);
        }

        private void ptSendClearBtn_Click(object sender, EventArgs e)
        {
            ptToSendTxb.Clear();
        }        

        #endregion

        #region packet mode requests tab

        private void ptQueryBtn_Click(object sender, EventArgs e)
        {
            if (port.PacketMode_Request(ptQueryTargetAddress, ptQueryDataID))
            {                    
                OnTransactionStart();
            }
        }

        private void ptQueryHistoryClearBtn_Click(object sender, EventArgs e)
        {
            ptQueryHistoryTxb.Clear();
        }

        #endregion

        #region rawModePanel

        private void rawSendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var textToSend = rawSendTxb.Text;
                port.RawDataSend(Encoding.ASCII.GetBytes(textToSend));

                var hString = string.Format("<< {0}\r\n", textToSend);
                rawHistoryTxb.AppendText(hString);
                logger.Write(hString);
                
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void rawSendTxb_TextChanged(object sender, EventArgs e)
        {
            rawSendBtn.Enabled = !string.IsNullOrEmpty(rawSendTxb.Text);
        }

        private void rawHistoryTxb_TextChanged(object sender, EventArgs e)
        {
            rawHistoryTxb.ScrollToCaret();
        }

        private void generateDatetimeStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = string.Format("[uWAVE Modem test {0}, {1}]", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void random8byteStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = GetRandomString(8);
        }

        private void random16byteStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = GetRandomString(16);
        }

        private void random32byteStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = GetRandomString(32);
        }

        private void random64byteStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = GetRandomString(64);
        }

        private void random128byteStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Text = GetRandomString(128);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawSendTxb.Clear();
        }

        #endregion                        

        #endregion

        #endregion
    }
}
