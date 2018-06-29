using System;
using System.IO.Ports;
using System.Windows.Forms;
using UCNLDrivers;

namespace uWAVE_Host
{
    public partial class SettingsEditor : Form
    {
        #region Properties

        public SettingsContainer Value
        {
            get
            {
                SettingsContainer result = new SettingsContainer();
                result.SetDefaults();

                if (portNameCbx.SelectedItem != null)
                    result.PortName = portNameCbx.SelectedItem.ToString();

                if (baudRateCbx.SelectedItem != null)
                    result.PortBaudrate = (BaudRate)Enum.Parse(typeof(BaudRate), baudRateCbx.SelectedItem.ToString());

                return result;
            }
            set
            {
                int idx = -1;

                idx = portNameCbx.Items.IndexOf(value.PortName);
                if (idx >= 0)
                    portNameCbx.SelectedIndex = idx;

                idx = baudRateCbx.Items.IndexOf(value.PortBaudrate.ToString());
                if (idx >= 0)
                    baudRateCbx.SelectedIndex = idx;
            }
        }

        #endregion

        #region Constructor

        public SettingsEditor()
        {
            InitializeComponent();


            baudRateCbx.Items.AddRange(Enum.GetNames(typeof(BaudRate)));
            baudRateCbx.SelectedIndex = 0;

            portNameCbx.Items.AddRange(SerialPort.GetPortNames());
            if (portNameCbx.Items.Count > 0)
            {
                portNameCbx.SelectedIndex = 0;
                portNameCbx.Enabled = true;
                okBtn.Enabled = true;
            }
            else
            {
                okBtn.Enabled = false;
                portNameCbx.Enabled = false;
            }
        }

        #endregion
    }
}
