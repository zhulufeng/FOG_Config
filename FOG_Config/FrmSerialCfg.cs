using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FOG_Config
{
    public partial class FrmSerialCfg : Form
    {
        public FrmSerialCfg()
        {
            InitializeComponent();
            setComBox();
            cmbox_BaudRate.SelectedIndex = 8;
            cmbox__DataBit.SelectedIndex = 1;
            cmbox_StopBit.SelectedIndex = 1;
            cmbox_ParityBit.SelectedIndex = 1;

        }

     

        private void setComBox()
        {
            string[] ArryPort = SerialPort.GetPortNames();//搜索
            cmbox_SerialNum.Items.Clear();
            for (int i = 0; i < ArryPort.Length; i++)
            {
                cmbox_SerialNum.Items.Add(ArryPort[i]);
            }
            if (ArryPort.Length > 0)
            {
                cmbox_SerialNum.SelectedIndex = 0;
            }
            else
            {
                cmbox_SerialNum.SelectedIndex = -1;
            }
            

        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            serialParameter.comName = cmbox_SerialNum.SelectedItem.ToString();
            serialParameter.baudRate = cmbox_BaudRate.SelectedItem.ToString();
            serialParameter.dataBit = cmbox__DataBit.SelectedItem.ToString();
            serialParameter.stopBit = cmbox_StopBit.SelectedItem.ToString();
            serialParameter.parityBit = cmbox_ParityBit.SelectedItem.ToString();
        }

  
    }
}
