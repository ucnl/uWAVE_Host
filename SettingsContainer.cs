using System;
using System.Text;
using UCNLDrivers;

namespace uWAVE_Host
{
    [Serializable]
    public class SettingsContainer
    {
        #region Properties

        public string PortName;
        public BaudRate PortBaudrate;

        #endregion

        #region Constructor

        public SettingsContainer()
        {
            SetDefaults();
        }

        #endregion

        #region Methods

        public void SetDefaults()
        {
            PortName = "COM1";
            PortBaudrate = BaudRate.baudRate9600;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Settings:\r\nPortName: {0}\r\n", PortName);
            sb.AppendFormat("PortBaudrate: {0}\r\n", PortBaudrate);

            return sb.ToString();
        }

        #endregion
    }
}
