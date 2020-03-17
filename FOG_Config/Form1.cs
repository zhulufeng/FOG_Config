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
        StreamWriter SW_CfgFile = null;
        public Form1()
        {
            InitializeComponent();
            DelgeateShow = new UpdateDataEventHandler(ShowRceiveData);
            ReadConfigData();
            TBox_2pi.Text = "0";
            TBOX_LoopGain.Text = "0";
            TBox_UpFreq.Text = "前面没有了！";
            TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
            TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();

            Btn_OpenSerial.Enabled = false;
            Btn_GyroNoInput.Enabled = false;
            Btn_ConfigUart.Enabled = false;
            Btn_SendData.Enabled = false;
            Btn_SendPi.Enabled = false;
            Btn_LoopGain.Enabled = false;
            Btn_GetCfgData.Enabled = false;
            Btn_Reset.Enabled = false;
            Btn_ModuleData.Enabled = false;
        }
        Dictionary<int, string> FreqDataDic = new Dictionary<int, string>();
        List<int> FreqList = new List<int>();
        List<string> DataList = new List<string>();
        int FreqIndex = 0;
        public void ReadConfigData()
        {
            StreamReader SR = new StreamReader("配置参数.txt");
            string dataLine;//一行字符串
            string[] dataSplited;//分割后字符串数组

            char[] rnSplitChar = new char[] { '\r', '\n' };//分割符号
            char[] trnSplitChar = new char[] { '\r', '\n', '\t', ' ' };
            double Freqdata = 0.0;
            string Hexdata = "";
            string[] HexdataArray = new string[14];

            while (!SR.EndOfStream)
            {
                dataLine = SR.ReadLine();
                dataSplited = dataLine.Split(trnSplitChar, StringSplitOptions.RemoveEmptyEntries);//开始分割
                Freqdata = Convert.ToDouble(dataSplited[0]);
                Hexdata = dataSplited[1];
                FreqDataDic.Add(Convert.ToInt32(Freqdata / 1000), Hexdata);
                FreqList.Add(Convert.ToInt32(Freqdata / 1000));
                DataList.Add(Hexdata);
            }

            SR.Close();

        }
        private void Btn_OpenSerial_Click(object sender, EventArgs e)
        {

            if (Btn_OpenSerial.Text == "再次打开串口...")
            {
                byte[] Sendbuff = new byte[4];
                Btn_OpenSerial.Text = "关闭串口...";
                try
                {
                    serialPort.Open();
                    InfoBox.Text += "串口已经打开！" + "\r\n";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("串口打开失败！");
                    Btn_OpenSerial.Text = "再次打开串口...";
                }
                /*
                Sendbuff[0] = 0xDE;
                serialData.DebugSendFlag = true;

                serialPort.Write(Sendbuff, 0, 1);
                Debug_Timer.Start();
                
                InfoBox.Text += "发送调试码，连接陀螺中...";

                InfoBox.Text += "\r\n";*/
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
                try
                {
                    serialPort.Open();
                    InfoBox.Text += "串口已经打开！" + "\r\n";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("串口打开失败！");
                    Btn_OpenSerial.Text = "打开串口...";
                }

                /*
                 Sendbuff[0] = 0xDE;
                 serialData.DebugSendFlag = true;

                 serialPort.Write(Sendbuff, 0, 1);
                 Debug_Timer.Start();
                 InfoBox.Text += "发送调试码，连接陀螺中..."; ;

                 InfoBox.Text += "\r\n";*/
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
            serialData.DebugSendFreqFlag = true;
            serialPort.Write(BytedataArray, 0, 14);
            Debug_Timer.Start();
            InfoBox.Text += "发送的频率是：" + FreqList[FreqIndex].ToString() + "\r\n";
            InfoBox.Text += "对应数据码是：" + "\r\n";
            for (int i = 0; i < BytedataArray.Length; i++)
            {
                InfoBox.Text += "0x" + BytedataArray[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
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
            if (serialData.DebugSendFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0xDE)
                    {
                        serialData.DebugFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSendFreqFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x1A)
                    {
                        serialData.DebugFreqFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSend2piFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x1B)
                    {
                        serialData.Debug2piFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSendLoopGainFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x1C)
                    {
                        serialData.DebugLoopGainFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSendUartCFGFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x1D)
                    {
                        serialData.DebugUartCFGFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSendModuleFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x1E)
                    {
                        serialData.DebugModuleFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (!serialData.DebugFlag)
            {
                serialData.ReceiveData.Clear();
            }
            else
            {
                while (serialData.ReceiveData.Count >= 64)//58
                {
                    if (serialData.ReceiveData[0] == 0x55 && serialData.ReceiveData[1] == 0xFB)
                    {
                        this.Invoke(DelgeateShow);
                        //
                        //ShowRceiveData();
                    }
                    else
                    {
                        serialData.ReceiveData.RemoveRange(0, 1);
                    }
                }
            }


        }

        private void ShowRceiveData()
        {
            byte[] tempByteList = new byte[20];
            string tempFreq = null;
            int FreqIndex = 0;
            int Triggerdata, Protocodata, Bauddata, Upddata = 0;
            MyVersionInfo.CoreID = null;
            MyVersionInfo.FuncInfo = null;
            InfoBox.Text += "应答参数是：";
            for (int i = 0; i < serialData.ReceiveData.Count; i++)
            {
                InfoBox.Text += "0x" + serialData.ReceiveData[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
            InfoBox.Text += "总共字节数是：" + serialData.ReceiveData.Count.ToString() + "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
            serialData.ReceiveData.CopyTo(2, tempByteList, 0, 14);
            for (int i = 0; i < 14; i++)
            {
                tempFreq += tempByteList[i].ToString("X2");
            }
            try
            {
                FreqIndex = DataList.IndexOf(tempFreq);
                CustomData.clkFreq = FreqList[FreqIndex];
            }
            catch (System.Exception ex)
            {
                FreqIndex = 0;
                CustomData.clkFreq = FreqList[FreqIndex];
            }


            serialData.ReceiveData.CopyTo(18, tempByteList, 0, 2);
            CustomData.Volt2pi = Convert.ToInt32(tempByteList[1]) + Convert.ToInt32(tempByteList[0]) * 256;

            serialData.ReceiveData.CopyTo(22, tempByteList, 0, 2);
            CustomData.LoopGain = Convert.ToInt32(tempByteList[1]) + Convert.ToInt32(tempByteList[0]) * 256;
            //读取调制配置参数
            serialData.ReceiveData.CopyTo(24, tempByteList, 0, 6);
            CustomData.Moduledata = Convert.ToInt32(tempByteList[5]) + Convert.ToInt32(tempByteList[4]) * 256 + Convert.ToInt32(tempByteList[3]) * 256 * 256 + Convert.ToInt32(tempByteList[2]) * 256 * 256 * 256;
            //读取通讯配置参数
            serialData.ReceiveData.CopyTo(30, tempByteList, 0, 6);
           // serialData.ReceiveData.CopyTo(24, tempByteList, 0, 6);
            Triggerdata = Convert.ToInt32(tempByteList[2]);
            Protocodata = Convert.ToInt32(tempByteList[3]);
            Bauddata = Convert.ToInt32(tempByteList[4]);
            Upddata = Convert.ToInt32(tempByteList[5]);

            serialData.ReceiveData.CopyTo(36, tempByteList, 0, 16);
            //serialData.ReceiveData.CopyTo(30, tempByteList, 0, 16);
            MyVersionInfo.FGyroType = Convert.ToInt32(tempByteList[2]);
            for (int i = 0; i < 5; i++)
            {
                MyVersionInfo.Softime[i] = Convert.ToInt32(tempByteList[4 + i]);
                MyVersionInfo.HexTime[i] = Convert.ToInt32(tempByteList[10 + i]);
            }
            MyVersionInfo.DotNum = Convert.ToInt32(tempByteList[15]);
            serialData.ReceiveData.CopyTo(52, tempByteList, 0, 8);
            //serialData.ReceiveData.CopyTo(46, tempByteList, 0, 8);
            for (int i = 0; i < 8; i++)
            {
                MyVersionInfo.CoreID += tempByteList[i].ToString("X2");
            }
            serialData.ReceiveData.CopyTo(60, tempByteList, 0, 4);
            //serialData.ReceiveData.CopyTo(54, tempByteList, 0, 4);
            for (int i = 0; i < 4; i++)
            {
                MyVersionInfo.FuncInfo += tempByteList[i].ToString("X2");
            }
            InfoBox.Text += "\r\n" + "陀螺配置参数：" + "\r\n";
            InfoBox.Text += "时钟频率：" + FreqIndex.ToString() + "\r\n";
            InfoBox.Text += "2π电压：" + CustomData.Volt2pi.ToString() + "\r\n";
            InfoBox.Text += "环路增益：" + CustomData.LoopGain.ToString() + "\r\n";
            InfoBox.Text += "调制参数：0x" + CustomData.Moduledata.ToString("X8") + "\r\n";
            InfoBox.Text += "\r\n" + "通讯协议：" + "\r\n";
            InfoBox.Text += "触发方式：" + UartData.TriggerString[Triggerdata] + "\r\n";
            InfoBox.Text += "通讯协议：" + UartData.ProtocolString[Protocodata] + "\r\n";
            InfoBox.Text += "波特率：" + UartData.BaudString[Bauddata] + "\r\n";
            InfoBox.Text += "更新率：" + UartData.UpdString[Upddata] + "\r\n";
            InfoBox.Text += "\r\n" + "版本信息：" + "\r\n";
            InfoBox.Text += "产品代号：" + CustomData.strGyroID[MyVersionInfo.FGyroType - 1] + "\r\n";
            InfoBox.Text += "FF时间：";
            for (int i = 0; i < 4; i++)
            {
                InfoBox.Text += MyVersionInfo.Softime[i].ToString() + "-";
            }
            InfoBox.Text += MyVersionInfo.Softime[4].ToString() + "\r\n";
            InfoBox.Text += "CC时间：";
            for (int i = 0; i < 4; i++)
            {
                InfoBox.Text += MyVersionInfo.HexTime[i].ToString() + "-";
            }
            InfoBox.Text += MyVersionInfo.HexTime[4].ToString() + "\r\n";
            InfoBox.Text += "点数：" + MyVersionInfo.DotNum.ToString() + "\r\n";
            InfoBox.Text += "芯片ID：" + MyVersionInfo.CoreID + "\r\n";
            InfoBox.Text += "功能标志：" + MyVersionInfo.FuncInfo + "\r\n";
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
            serialData.DebugSend2piFlag = true;
            serialPort.Write(Sendbuff, 0, 4);
            Volt_Timer.Start();
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
            serialData.DebugSendLoopGainFlag = true;
            serialPort.Write(Sendbuff, 0, 4);
            Loop_Timer.Start();
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
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开，打开串口后重试！");
                return;
            }
            serialData.DebugSendFlag = true;
            serialPort.Write(Sendbuff, 0, 1);
            Debug_Timer.Start();
            InfoBox.Text += "发送调试码，连接陀螺中...";

            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_GyroNoInput_Click(object sender, EventArgs e)
        {
            FrmGyroNoSetDlg gyroNoSetDlg = new FrmGyroNoSetDlg();
            if (gyroNoSetDlg.ShowDialog() != DialogResult.Cancel)
            {
                CustomData.GyroTypeNo = CustomData.GyroType + '_' + CustomData.GyroNo;
                PathString.CFGDataCurrentDirectory = PathString.CFGDataBaseDirectory + @"\" + "GyroCfgData" + CustomData.GyroTypeNo;
                Directory.CreateDirectory(PathString.CFGDataBaseDirectory);
                Directory.CreateDirectory(PathString.CFGDataCurrentDirectory);
                SW_CfgFile = new StreamWriter(PathString.CFGDataCurrentDirectory + @"\" + "CfgData.txt", true);

            }

        }

        private void Btn_ConfigUart_Click(object sender, EventArgs e)
        {
            FrmConfigUart CfgUartDlg = new FrmConfigUart();
            byte[] Sendbuff = new byte[6];


            if (CfgUartDlg.ShowDialog() != DialogResult.Cancel)
            {
                for (int i = 0; i < 6; i++)
                {
                    Sendbuff[i] = Convert.ToByte(UartData.UartInfo[i] & 0xFF);
                }
                serialPort.Write(Sendbuff, 0, 6);
                InfoBox.Text += "配置通讯协议：" + "\r\n";
                InfoBox.Text += "触发方式：" + UartData.TriggerString[UartData.UartInfo[2]] + "\r\n";
                InfoBox.Text += "通讯协议：" + UartData.ProtocolString[UartData.UartInfo[3]] + "\r\n";
                InfoBox.Text += "波特率：" + UartData.BaudString[UartData.UartInfo[4]] + "\r\n";
                InfoBox.Text += "更新率：" + UartData.UpdString[UartData.UartInfo[5]] + "\r\n";
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
        }

        private void Btn_GetCfgData_Click(object sender, EventArgs e)
        {
            byte[] Sendbuff = new byte[4];
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0xFB;
            Sendbuff[2] = 0xFF;
            Sendbuff[3] = 0xFF;
            serialPort.Write(Sendbuff, 0, 4);

            InfoBox.Text += "回传配置参数！";

            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {

            byte[] BytedataArray = new byte[14];
            string Hexdata = FreqDataDic[18269];
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口还没有打开！");
                return;
            }
            serialData.DebugResetFlag = true;
            InfoBox.Text += "发送频率调制参数！";
            for (int i = 0; i < Hexdata.Length / 2; i++)
            {
                BytedataArray[i] = Convert.ToByte(Hexdata.Substring(2 * i, 2), 16);
            }
            serialData.DebugSendFreqFlag = true;
            serialPort.Write(BytedataArray, 0, 14);
            Debug_Timer.Start();
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();

        }
        private void TimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            Debug_Timer.Stop();
            if (serialData.DebugSendFlag)
            {
                if (serialData.DebugFlag)
                {
                    InfoBox.Text += "连接上陀螺，进入调试模式！";
                    InfoBox.Text += "\r\n";
                    Btn_ConfigUart.Enabled = true;
                    Btn_SendData.Enabled = true;
                    Btn_SendPi.Enabled = true;
                    Btn_LoopGain.Enabled = true;
                    Btn_GetCfgData.Enabled = true;
                    Btn_Reset.Enabled = true;
                    Btn_ModuleData.Enabled = true;
                }
                else
                {
                    InfoBox.Text += "无法连接上陀螺，请检查通讯协议后重新上电测试！";
                    InfoBox.Text += "\r\n";
                }
                serialData.DebugSendFlag = false;
            }
            if (serialData.DebugSendFreqFlag)
            {
                if (serialData.DebugFreqFlag)
                {
                    InfoBox.Text += "频率设置成功！";
                    InfoBox.Text += "\r\n";
                    if (serialData.DebugResetFlag)
                    {
                        Send2piVolt();
                    }

                }
                else
                {
                    InfoBox.Text += "频率设置不成功！";
                    InfoBox.Text += "\r\n";
                }
                serialData.DebugSendFreqFlag = false;
                serialData.DebugFreqFlag = false;

            }


            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
        private void Send2piVolt()
        {
            byte[] BytedataArray = new byte[14];


            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xBB;
            BytedataArray[2] = 0xC4;//DA
            BytedataArray[3] = 0x00;
            InfoBox.Text += "发送默认2π电压参数！";

            serialData.DebugSend2piFlag = true;
            serialPort.Write(BytedataArray, 0, 4);
            Volt_Timer.Start();

            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();

        }

        private void SendLoopGain()
        {

            byte[] BytedataArray = new byte[14];
            InfoBox.Text += "发送默认环路增益参数！";
            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xCC;
            BytedataArray[2] = 0x10;
            BytedataArray[3] = 0x00;

            serialData.DebugSendLoopGainFlag = true;
            serialPort.Write(BytedataArray, 0, 4);
            Loop_Timer.Start();
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();

        }
        private void SendUartCfg()
        {
            byte[] BytedataArray = new byte[14];
            InfoBox.Text += "发送默认通讯协议配置参数！";
            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xDD;
            BytedataArray[2] = 0x00;
            BytedataArray[3] = 0x00;
            BytedataArray[2] = 0x00;
            BytedataArray[3] = 0x00;
            serialData.DebugSendUartCFGFlag = true;
            serialPort.Write(BytedataArray, 0, 6);
            UartCFG_Timer.Start();
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();

        }
        private void SendModuleData()
        {
            byte[] BytedataArray = new byte[14];
            InfoBox.Text += "发送默认调制配置参数！";
            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xEE;
            BytedataArray[2] = 0x00;
            BytedataArray[3] = 0x00;
            BytedataArray[4] = 0x3F;
            BytedataArray[5] = 0xFF;
            serialData.DebugSendModuleFlag = true;
            serialPort.Write(BytedataArray, 0, 6);
            Module_Timer.Start();
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();

        }
        private void VoltTimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            Volt_Timer.Stop();
            if (serialData.DebugSend2piFlag)
            {
                if (serialData.Debug2piFlag)
                {
                    InfoBox.Text += "2π电压设置成功！";
                    InfoBox.Text += "\r\n";
                    if (serialData.DebugResetFlag)
                    {
                        SendLoopGain();
                    }

                }
                else
                {
                    InfoBox.Text += "2π电压设置不成功！";
                    InfoBox.Text += "\r\n";
                }
                serialData.Debug2piFlag = false;
                serialData.DebugSend2piFlag = false;

            }
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
        private void LoopTimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            Loop_Timer.Stop();
            if (serialData.DebugSendLoopGainFlag)
            {
                if (serialData.DebugLoopGainFlag)
                {
                    InfoBox.Text += "环路增益设置成功！";
                    InfoBox.Text += "\r\n";
                    if (serialData.DebugResetFlag)
                    {
                        SendModuleData();
                    }

                }
                else
                {
                    InfoBox.Text += "环路增益设置不成功！";
                    InfoBox.Text += "\r\n";
                }
                serialData.DebugLoopGainFlag = false;
                serialData.DebugSendLoopGainFlag = false;
                serialData.NextStepEnable = true;
            }
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();



        }
        private void UartCfgTimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            UartCFG_Timer.Stop();
            if (serialData.DebugSendUartCFGFlag)
            {
                if (serialData.DebugUartCFGFlag)
                {
                    InfoBox.Text += "通讯参数设置成功！";
                    InfoBox.Text += "\r\n";
                    InfoBox.Text += "全部默认参数设置成功！";
                    InfoBox.Text += "\r\n";

                    //                     if (serialData.DebugResetFlag)
                    //                     {
                    //                         SendModuleData();
                    //                     }

                }
                else
                {
                    InfoBox.Text += "通讯参数设置不成功！";
                    InfoBox.Text += "\r\n";
                }
                serialData.DebugSendUartCFGFlag = false;
                serialData.DebugUartCFGFlag = false;
                serialData.NextStepEnable = true;
            }
            serialData.DebugResetFlag = false;
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void numericUpDown_FreqInex_ValueChanged(object sender, EventArgs e)
        {
            FreqIndex = Convert.ToInt32(numericUpDown_FreqInex.Value);
            if (FreqIndex == 0)
            {
                TBox_UpFreq.Text = "前面没有了！";
                TBox_NowFreq.Text = (Convert.ToDouble(FreqList[FreqIndex])).ToString();
                TBox_NextFreq.Text = (Convert.ToDouble(FreqList[FreqIndex + 1])).ToString();

            }
            else if (FreqIndex == FreqList.Count)
            {

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
        }

        private void Btn_ClearBox_Click(object sender, EventArgs e)
        {
            InfoBox.Clear();
        }

        private void Btn_ModuleData_Click(object sender, EventArgs e)
        {
            UInt32 moduledata;
            UInt32 temp = 0xFFFFFFFF;
            int numOfones;
            byte[] BytedataArray = new byte[6];

            numOfones = Convert.ToInt16(numericUpDown_Module.Value);
            moduledata = temp >> (32 - numOfones);
            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xEE;
            BytedataArray[2] = Convert.ToByte((moduledata >> 24) & 0xFF);
            BytedataArray[3] = Convert.ToByte((moduledata >> 16) & 0xFF);
            BytedataArray[4] = Convert.ToByte((moduledata >> 8) & 0xFF);
            BytedataArray[5] = Convert.ToByte(moduledata & 0xFF);

            serialData.DebugSendModuleFlag = true;
            serialPort.Write(BytedataArray, 0, 6);
            Module_Timer.Start();
            InfoBox.Text += "发送的调制参数是：0x" + moduledata.ToString("X8") + "\r\n";
            InfoBox.Text += "对应数据码是：" + "\r\n";
            for (int i = 0; i < BytedataArray.Length; i++)
            {
                InfoBox.Text += "0x" + BytedataArray[i].ToString("X2") + " ";
            }
            InfoBox.Text += "\r\n";
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
        private void ModuleTimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            Module_Timer.Stop();
            if (serialData.DebugSendModuleFlag)
            {
                if (serialData.DebugModuleFlag)
                {
                    InfoBox.Text += "调制参数设置成功！";
                    InfoBox.Text += "\r\n";
                    if (serialData.DebugResetFlag)
                    {
                        SendUartCfg();
                    }
                    
                }
                else
                {
                    InfoBox.Text += "调制参数设置不成功！";
                    InfoBox.Text += "\r\n";

                }
                serialData.DebugModuleFlag = false;
                serialData.DebugSendModuleFlag = false;

            }
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
    }
}
