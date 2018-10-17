using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uWAVE_Host
{
    public partial class MiscSettingsDialog : Form
    {
        #region Properties

        public int PeriodMs
        {
            get
            {
                return Convert.ToInt32(periodMsEdit.Value);
            }
            set
            {
                periodMsEdit.Value = value;
            }
        }

        public bool IsPressure
        {
            get
            {
                return isPressureCxb.Checked;
            }
            set
            {
                isPressureCxb.Checked = value;
            }
        }

        public bool IsTemperature
        {
            get
            {
                return isTempCxb.Checked;
            }
            set
            {
                isTempCxb.Checked = value;
            }
        }

        public bool IsDepth
        {
            get
            {
                return isDepthCxb.Checked;
            }
            set
            {
                isDepthCxb.Checked = value;
            }
        }

        public bool IsBatV
        {
            get
            {
                return isBatVCxb.Checked;
            }
            set
            {
                isBatVCxb.Checked = value;
            }
        }

        public bool IsSaveInFlash
        {
            get
            {
                return isSaveInFlashCxb.Checked;
            }
            set
            {
                isSaveInFlashCxb.Checked = value;
            }
        }

        #endregion


        public MiscSettingsDialog()
        {
            InitializeComponent();
        }
    }
}
