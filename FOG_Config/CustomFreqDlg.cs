using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOG_Config
{
    public partial class CustomFreqDlg : Form
    {
        public CustomFreqDlg()
        {
            InitializeComponent();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            CustomData.CustomFreq = Convert.ToInt32(TBOX_CustomFreq.Text);
        }
    }
}
