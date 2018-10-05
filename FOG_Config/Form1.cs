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
using System.IO;

namespace FOG_Config
{
    public partial class Form1 : Form
    {
        delegate void UpdateDataEventHandler();
        UpdateDataEventHandler DelgeateShow;
        public Form1()
        {
            InitializeComponent();
            DelgeateShow = new UpdateDataEventHandler(ShowRceiveData);
            ReadConfigData();
            TBox_2pi.Text = "0";
            TBOX_LoopGain.Text = "0";
            TBox_UpFreq.Text = "前面没有了！";
            TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
            TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex+1])).ToString();
            if (FreqIndex == 0)
            {
                Btn_SendUp.Enabled = false;
            }
            Btn_OpenSerial.Enabled = false;
        }
        Dictionary<int, string> FreqDataDic = new Dictionary<int, string>();
        List<int> FreqList = new List<int>();
        int FreqIndex = 0;
        public void ReadConfigData()
        {
            StreamReader SR = new StreamReader("配置参数.txt");
            string dataLine;//一行字符串
            string[] dataSplited;//分割后字符串数组
            
            char[] rnSplitChar = new char[] { '\r', '\n' };//分割符号
            char[] trnSplitChar = new char[] { '\r', '\n', '\t', ' ' };
            double Freqdata = 0.0;
            string Hexdata ="";
            string[] HexdataArray = new string[14];

            while (!SR.EndOfStream)
            {
                dataLine = SR.ReadLine();
                dataSplited = dataLine.Split(trnSplitChar, StringSplitOptions.RemoveEmptyEntries);//开始分割
                Freqdata = Convert.ToDouble(dataSplited[0]);
                Hexdata = dataSplited[1];
                FreqDataDic.Add(Convert.ToInt32(Freqdata / 1000), Hexdata);
                FreqList.Add(Convert.ToInt32(Freqdata / 1000));
            }

            SR.Close();

        }
        private void Btn_OpenSerial_Click(object sender, EventArgs e)
        {

            if (Btn_OpenSerial.Text == "再次打开串口...")
            {
                byte[] Sendbuff = new byte[4];
                Btn_OpenSerial.Text = "关闭串口...";
                serialPort.Open();

                Sendbuff[0] = 0xDE;


                serialPort.Write(Sendbuff, 0, 1);

                InfoBox.Text += "进入调试模式，数据发送停止！";

                InfoBox.Text += "\r\n";
                //让文本框获取焦点 
                this.InfoBox.Focus();
                //设置光标的位置到文本尾 
                this.InfoBox.Select(this.InfoBox.Text.Length, 0);
                //滚动到控件光标处 
                this.InfoBox.ScrollToCaret();
            }
            else if (Btn_OpenSerial.Text == "打开串口...")
            {
                byte[] Sendbuff = new byte[4];
                Btn_OpenSerial.Text = "关闭串口...";
                serialPort.Open();
                
                Sendbuff[0] = 0xDE;


                serialPort.Write(Sendbuff, 0, 1);

                InfoBox.Text += "进入调试模式，数据发送停止！";

                InfoBox.Text += "\r\n";
                //让文本框获取焦点 
                this.InfoBox.Focus();
                //设置光标的位置到文本尾 
                this.InfoBox.Select(this.InfoBox.Text.Length, 0);
                //滚动到控件光标处 
                this.InfoBox.ScrollToCaret();
            }
            else
            {
                Btn_OpenSerial.Text = "再次打开串口...";
                serialPort.Close();
            }

        }
        private void Btn_SerialCfg_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Btn_OpenSerial.Enabled = false;
            Btn_OpenSerial.Text = "打开串口...";
            FrmSerialCfg serialCfgDlg = new FrmSerialCfg();
            if (serialCfgDlg.ShowDialog() != DialogResult.Cancel)
            {
                InfoBox.Text = "串口号：" + serialParameter.comName + "\r\n";
                InfoBox.Text += "波特率：" + serialParameter.baudRate + "\r\n";
                InfoBox.Text += "数据位：" + serialParameter.dataBit + "\r\n";
                InfoBox.Text += "停止位：" + serialParameter.stopBit + "\r\n";
                InfoBox.Text += "校验位：" + serialParameter.parityBit + "\r\n";

                serialPort.PortName = serialParameter.comName;
                serialPort.BaudRate = int.Parse(serialParameter.baudRate);
                serialPort.DataBits = Convert.ToInt32(serialParameter.dataBit);
                switch (serialParameter.stopBit)
                {
                    case "1":
                        serialPort.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        serialPort.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        serialPort.StopBits = StopBits.Two;
                        break;
                    default:
                        serialPort.StopBits = StopBits.One;
                        break;
                }
                switch (serialParameter.parityBit)
                {
                    case "odd":
                        serialPort.Parity = Parity.Odd;
                        break;
                    case "even":
                        serialPort.Parity = Parity.Even;
                        break;
                    case "none":
                        serialPort.Parity = Parity.None;
                        break;
                    default:
                        serialPort.Parity = Parity.None;
                        break;
                }
                Btn_OpenSerial.Enabled = true;
            }
        }

        private void Btn_SendUp_Click(object sender, EventArgs e)
        {
            FreqIndex--;
            if (FreqIndex == 0)
            {
                TBox_UpFreq.Text = "前面没有了！";
                TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();
                Btn_SendUp.Enabled = false;
            }
            else
            {
                TBox_UpFreq.Text  = (Convert.ToDouble(FreqList[FreqIndex - 1])).ToString();
                TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();
            }
            Btn_SendDown.Enabled = true;
        }

        private void Btn_SendDown_Click(object sender, EventArgs e)
        {
            FreqIndex++;
            if (FreqIndex == FreqList.Count)
            {
                Btn_SendDown.Enabled = false;
                TBox_UpFreq.Text = (Convert.ToDouble(FreqList[FreqIndex - 1])).ToString();
                TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                TBox_NextFreq.Text = "后面没有了！";
            }
            else
            {
                TBox_UpFreq.Text = (Convert.ToDouble(FreqList[FreqIndex - 1])).ToString();
                TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();
            }
            Btn_SendUp.Enabled = true;
        }

        private void Btn_CustomFreq_Click(object sender, EventArgs e)
        {
            CustomFreqDlg custmFreqDlg = new CustomFreqDlg();
            if (custmFreqDlg.ShowDialog() != DialogResult.Cancel)
            {
                FreqIndex = FreqList.IndexOf(CustomData.CustomFreq);
                if (FreqIndex == 0)
                {
                    TBox_UpFreq.Text = "前面没有了！";
                    TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                    TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();
                    Btn_SendUp.Enabled = false;
                }
                else if (FreqIndex == FreqList.Count)
                {
                    Btn_SendDown.Enabled = false;
                    TBox_UpFreq.Text = (Convert.ToDouble(FreqList[FreqIndex - 1])).ToString();
                    TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                    TBox_NextFreq.Text = "后面没有了！";
                }
                else
                {
                    TBox_UpFreq.Text = (Convert.ToDouble(FreqList[FreqIndex - 1])).ToString();
                    TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                    TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();
                    Btn_SendUp.Enabled   = true;
                    Btn_SendDown.Enabled = true;
                }
            }
        }

        private void Btn_SendData_Click(object sender, EventArgs e)
        {
            byte[] BytedataArray = new byte[14];
            string Hexdata = FreqDataDic[FreqList[FreqIndex]];
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口还没有打开！");
                return;
            }
            for (int i = 0; i < Hexdata.Length / 2; i++)
            {
                BytedataArray[i] = Convert.ToByte(Hexdata.Substring(2 * i, 2), 16);
            }
            serialPort.Write(BytedataArray, 0, 14);
            InfoBox.Text += "发送的频率是：" + FreqList[FreqIndex].ToString() + "\r\n";
            InfoBox.Text += "对应数据码是：" + "\r\n";
            for (int i = 0; i < BytedataArray.Length ; i++)
            {
                InfoBox.Text += "0x" + BytedataArray[i].ToString("X2") + " ";
            }
            InfoBox.Text +=  "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort.BytesToRead;
            byte[] readBuffer = new byte[n];
            byte[] buf = new byte[n];
            serialPort.Read(readBuffer, 0, n);
            serialData.ReceiveData.AddRange(readBuffer);
            if (serialData.ReceiveData.Count >= 4)
            {
              if (serialData.ReceiveData[0] == 0x55)
              {
                    this.Invoke(DelgeateShow);
                    serialData.ReceiveData.RemoveRange(0, 4);
              }
              else
              {
                    serialData.ReceiveData.Clear();
              }
               
            }
           

         }

       private void ShowRceiveData()
        {
            InfoBox.Text += "应答参数是：";
            for (int i = 0; i < serialData.ReceiveData.Count; i++)
            {
                InfoBox.Text += "0x" + serialData.ReceiveData[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
            serialData.ReceiveData.Clear();
        }

        private void Btn_SendPi_Click(object sender, EventArgs e)
        {
            uint PiVolt = Convert.ToUInt16(TBox_2pi.Text);
            byte[] Sendbuff = new byte[4];
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口还没有打开！");
                return;
            }
            if (PiVolt > 635535)
            {
                MessageBox.Show(" 异常值！");
                return;
                    
            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0xBB;
            Sendbuff[2] = Convert.ToByte((PiVolt / 256) & 0xFF);
            Sendbuff[3] = Convert.ToByte(PiVolt & 0xFF);

            serialPort.Write(Sendbuff, 0, 4);

            InfoBox.Text += "发送的电压参数是：" + PiVolt.ToString() + "\r\n";
            InfoBox.Text += "对应数据码是：" + "\r\n";
            for (int i = 0; i < Sendbuff.Length; i++)
            {
                InfoBox.Text += "0x" + Sendbuff[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_LoopGain_Click(object sender, EventArgs e)
        {
            uint LoopGain = Convert.ToUInt16(TBOX_LoopGain.Text);
            byte[] Sendbuff = new byte[4];
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口还没有打开！");
                return;
            }
            if (LoopGain > 635535)
            {
                MessageBox.Show(" 异常值！");
                return;

            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0xCC;
            Sendbuff[2] = Convert.ToByte((LoopGain / 256) & 0xFF);
            Sendbuff[3] = Convert.ToByte(LoopGain & 0xFF);

            serialPort.Write(Sendbuff, 0, 4);

            InfoBox.Text += "发送的环路增益参数是：" + LoopGain.ToString() + "\r\n";
            InfoBox.Text += "对应数据码是：" + "\r\n";
            for (int i = 0; i < Sendbuff.Length; i++)
            {
                InfoBox.Text += "0x" + Sendbuff[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_Debug_Click(object sender, EventArgs e)
        {
            byte[] Sendbuff = new byte[4];
            Sendbuff[0] = 0xDE;
            

            serialPort.Write(Sendbuff, 0,1);

            InfoBox.Text += "进入调试模式，数据发送停止！";
                     
            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
    }
}
