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
    public partial class FrmGyroNoSetDlg : Form
    {
        public FrmGyroNoSetDlg()
        {
            InitializeComponent();
            this.comBox_GryoNo.SelectedIndex = 0;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            CustomData.GyroType = this.comBox_GryoNo.SelectedItem.ToString();
            CustomData.GyroNo = this.tBox_GyroNo.Text;
        }
    }
}
