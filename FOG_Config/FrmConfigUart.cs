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
    public partial class FrmConfigUart : Form
    {
        public FrmConfigUart()
        {
            InitializeComponent();
            this.rBtn_Trigger_woshou.Checked = true;
            this.rBtn_Baud_460.Checked = true;
            this.rbtn_protocol_buaa.Checked = true;
            this.rBtn_Upd_woshou.Checked = true;
        }


        private void Btn_OK_Click(object sender, EventArgs e)
        {
            UartData.UartInfo[0] = 0x55;
            UartData.UartInfo[1] = 0xDD;
            if (rBtn_Trigger_mangfa.Checked)
            {
                UartData.UartInfo[2] = (int)UartData.TriggerNum.mangfa;
                //rBtn_Upd_1000.Checked = true;
            }
            if (rBtn_Trigger_woshou.Checked)
            {
                UartData.UartInfo[2] = (int)UartData.TriggerNum.woshou;
            }
            //协议
            if (rbtn_protocol_buaa.Checked)
            {
                UartData.UartInfo[3] = (int)UartData.ProtocolNum.buaa;
            }
            if (rBtn_protocol_rainbow.Checked)
            {
                UartData.UartInfo[3] = (int)UartData.ProtocolNum.rainbow;
            }
            if (rBtn_protocol_180908.Checked)
            {
                UartData.UartInfo[3] = (int)UartData.ProtocolNum.ueser180908;
            }
            if (rBtn_protocol_reserve.Checked)
            {
                UartData.UartInfo[3] = (int)UartData.ProtocolNum.Reserve;
            }
            //波特率
            if (rBtn_Baud_460.Checked)
            {
                UartData.UartInfo[4] = (int)UartData.Buadrate.Buad460;
            }
            if (rBtn_Baud_115.Checked)
            {
                UartData.UartInfo[4] = (int)UartData.Buadrate.Buad115;
            }
            if (rBtn_Baud_614.Checked)
            {
                UartData.UartInfo[4] = (int)UartData.Buadrate.Buad614;
            }
            //
            if (rBtn_Upd_woshou.Checked)
            {
                UartData.UartInfo[5] = (int)UartData.Upd.Upd_woshou;
            }
            if (rBtn_Upd_400.Checked)
            {
                UartData.UartInfo[5] = (int)UartData.Upd.Upd_400Hz;
            }
            if (rBtn_Upd_1000.Checked)
            {
                UartData.UartInfo[5] = (int)UartData.Upd.Upd_1000Hz;
            }
            if (rBtn_Upd_2000.Checked)
            {
                UartData.UartInfo[5] = (int)UartData.Upd.Upd_2000Hz;
            }
        }

        private void rBtn_Upd_400_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Upd_400.Checked)
            {
                if (rBtn_Trigger_woshou.Checked)
                {
                    rBtn_Upd_400.Checked = false;
                    rBtn_Upd_1000.Checked = false;
                    rBtn_Upd_woshou.Checked = true;
                    MessageBox.Show("握手状态，不能选择更新率！");
                }
                else
                {
                    rBtn_Upd_400.Checked = true;
                    rBtn_Upd_1000.Checked = false;
                    rBtn_Upd_woshou.Checked = false;
                }
            }
        }

        private void rBtn_Upd_1000_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Upd_1000.Checked)
            {
                if (rBtn_Trigger_woshou.Checked)
                {
                    rBtn_Upd_1000.Checked = false;
                    rBtn_Upd_400.Checked = false;
                    rBtn_Upd_woshou.Checked = true;
                    MessageBox.Show("握手状态，不能选择更新率！");
                }
                else
                {
                    rBtn_Upd_1000.Checked = true;
                    rBtn_Upd_400.Checked = false;
                    rBtn_Upd_woshou.Checked = false;
                }
            }
        }

        private void rBtn_Upd_woshou_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Trigger_woshou.Checked)
            {
                if (rBtn_Trigger_mangfa.Checked)
                {
                    rBtn_Upd_woshou.Checked = false;
                    rBtn_Upd_400.Checked = false;
                    rBtn_Upd_1000.Checked = true;
                    
                    MessageBox.Show("盲发状态，必须选择更新率，默认为1000Hz！");
                }
            }
        }

        private void rBtn_Trigger_mangfa_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Trigger_mangfa.Checked)
            {
                rBtn_Upd_1000.Checked = true;
                rBtn_Upd_woshou.Checked = false;
                rBtn_Upd_400.Checked = false;
            }
        }
    }
}
