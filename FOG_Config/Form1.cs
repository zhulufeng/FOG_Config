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
        TemParacls temPara = new TemParacls();
        int send_debug_index = 0;
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
            byte[] BytedataArray = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                BytedataArray[i] = 0x00;
            }
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
            serialPort.Write(BytedataArray, 0, 18);
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
            //接收标度因数参数返回指令
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
            //接收零偏参数返回指令
            if (serialData.DebugSendSFtemParaFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x11)
                    {
                        serialData.DebugSFtemParaFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            //接收打开温补返回
            if (serialData.DebugSendtemParaONFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x33)
                    {
                        serialData.DebugtemParaONFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            //接收关闭温补返回
            if (serialData.DebugSendtemParaOFFFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x33)
                    {
                        serialData.DebugtemParaOFFFlag = true;
                        serialData.ReceiveData.Clear();
                    }

                }
            }
            if (serialData.DebugSendBiastemParaFlag)
            {
                for (int i = 0; i < serialData.ReceiveData.Count; i++)
                {
                    if (serialData.ReceiveData[i] == 0x22)
                    {
                        serialData.DebugBiastemParaFlag = true;
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
            CustomData.ModuledataNum = Convert.ToInt32(tempByteList[5]) + Convert.ToInt32(tempByteList[4]) * 256; 
            CustomData.ModuledataPara = Convert.ToInt32(tempByteList[3]) + Convert.ToInt32(tempByteList[2]) * 256;
            //读取通讯配置参数
            serialData.ReceiveData.CopyTo(30, tempByteList, 0, 6);
           // serialData.ReceiveData.CopyTo(24, tempByteList, 0, 6);
            Triggerdata = Convert.ToInt32(tempByteList[2]);
            Protocodata = Convert.ToInt32(tempByteList[3]);
            Bauddata = Convert.ToInt32(tempByteList[4]);
            Upddata = Convert.ToInt32(tempByteList[5]);
            //读取标度因数补偿系数
            serialData.ReceiveData.CopyTo(36, tempByteList, 0, 14);
            CustomData.SF_Kn = Convert.ToDouble(Convert.ToInt32(tempByteList[5]) + Convert.ToInt32(tempByteList[4]) * 256 +
                Convert.ToInt32(tempByteList[3]) * 256 * 256 + Convert.ToInt32(tempByteList[2]) * 256 * 256 * 256) / 1e12;
            
            CustomData.SF_K1 = Convert.ToDouble(Convert.ToInt32(tempByteList[9]) + Convert.ToInt32(tempByteList[8]) * 256 + 
                Convert.ToInt32(tempByteList[7]) * 256 * 256 + Convert.ToInt32(tempByteList[6]) * 256 * 256 * 256) / 65536.0;
            CustomData.SF_K2 = Convert.ToDouble(Convert.ToInt32(tempByteList[13]) + Convert.ToInt32(tempByteList[12]) * 256 +
                Convert.ToInt32(tempByteList[11]) * 256 * 256 + Convert.ToInt32(tempByteList[10]) * 256 * 256 * 256) / 65536.0;
            //读取零偏补偿系数
            serialData.ReceiveData.CopyTo(54, tempByteList, 0, 18);
            CustomData.Bias_Kt = Convert.ToDouble(Convert.ToInt32(tempByteList[5]) + Convert.ToInt32(tempByteList[4]) * 256 +
                Convert.ToInt32(tempByteList[3]) * 256 * 256 + Convert.ToInt32(tempByteList[2]) * 256 * 256 * 256) / 1024.0;
            CustomData.Bias_K3 = Convert.ToDouble(Convert.ToInt32(tempByteList[9]) + Convert.ToInt32(tempByteList[8]) * 256 +
                Convert.ToInt32(tempByteList[7]) * 256 * 256 + Convert.ToInt32(tempByteList[6]) * 256 * 256 * 256) / 65536.0;
            CustomData.Bias_K2 = Convert.ToDouble(Convert.ToInt32(tempByteList[13]) + Convert.ToInt32(tempByteList[12]) * 256 +
                Convert.ToInt32(tempByteList[11]) * 256 * 256 + Convert.ToInt32(tempByteList[10]) * 256 * 256 * 256) / 65536.0;
            CustomData.Bias_K1 = Convert.ToDouble(Convert.ToInt32(tempByteList[17]) + Convert.ToInt32(tempByteList[16]) * 256 +
                Convert.ToInt32(tempByteList[15]) * 256 * 256 + Convert.ToInt32(tempByteList[14]) * 256 * 256 * 256) / 65536.0;
            //读取温补开关参数
            serialData.ReceiveData.CopyTo(72, tempByteList, 0, 3);
            CustomData.TemComSwitch =Convert.ToInt32(tempByteList[2]);
            //读取版本信息
            serialData.ReceiveData.CopyTo(75, tempByteList, 0, 16);
            MyVersionInfo.FGyroType = Convert.ToInt32(tempByteList[2]);
            for (int i = 0; i < 5; i++)
            {
                MyVersionInfo.Softime[i] = Convert.ToInt32(tempByteList[4 + i]);
                MyVersionInfo.HexTime[i] = Convert.ToInt32(tempByteList[10 + i]);
            }
            MyVersionInfo.DotNum = Convert.ToInt32(tempByteList[15]);
            serialData.ReceiveData.CopyTo(91, tempByteList, 0, 8);
            //serialData.ReceiveData.CopyTo(46, tempByteList, 0, 8);
            for (int i = 0; i < 8; i++)
            {
                MyVersionInfo.CoreID += tempByteList[i].ToString("X2");
            }
            serialData.ReceiveData.CopyTo(99, tempByteList, 0, 4);
            //serialData.ReceiveData.CopyTo(54, tempByteList, 0, 4);
            for (int i = 0; i < 4; i++)
            {
                MyVersionInfo.FuncInfo += tempByteList[i].ToString("X2");
            }
            InfoBox.Text += "\r\n" + "陀螺配置参数：" + "\r\n";
            InfoBox.Text += "时钟频率：" + FreqIndex.ToString() + "\r\n";
            InfoBox.Text += "2π电压：" + CustomData.Volt2pi.ToString() + "\r\n";
            InfoBox.Text += "环路增益：" + CustomData.LoopGain.ToString() + "\r\n";
            InfoBox.Text += "阶梯波偏置系数：" + CustomData.ModuledataPara.ToString() + "\r\n";
            InfoBox.Text += "调制个数：" + CustomData.ModuledataNum.ToString() + "\r\n";
            InfoBox.Text += "发送的标度温补参数是：\r\nSF_Kn:  " + CustomData.SF_Kn.ToString() + "\tSF_K1:  " + CustomData.SF_K1.ToString() + "\tSF_K2: " + CustomData.SF_K2.ToString() + "\r\n";
            InfoBox.Text += "发送的零偏温补参数是：\r\n0318Bias_K1 " + CustomData.Bias_Kt.ToString() + "\tBias_K23: " + CustomData.Bias_K3.ToString()
                                + "\tBias_K22: " + CustomData.Bias_K2.ToString() + "\tBias_K21: " + CustomData.Bias_K1.ToString() + "\r\n";
            if (CustomData.TemComSwitch == 1)
            {
                InfoBox.Text += "温度补偿开启。"+"\r\n";
            }
            else
            {
                InfoBox.Text += "温度补偿关闭。" + "\r\n";
            }
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
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
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
            serialPort.Write(Sendbuff, 0, 18);
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
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
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
            serialPort.Write(Sendbuff, 0, 18);
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
            byte[] Sendbuff = new byte[5];
            Sendbuff[0] = Convert.ToByte('D');
            Sendbuff[1] = Convert.ToByte('E');
            Sendbuff[2] = Convert.ToByte('B');
            Sendbuff[3] = Convert.ToByte('U');
            Sendbuff[4] = Convert.ToByte('G');
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开，打开串口后重试！");
                return;
            }
            DialogResult dr;
            dr = MessageBox.Show("当前陀螺是盲发状态吗？", "确认对话框", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            InfoBox.Text += "发送调试码，连接陀螺中...\r\n";
            if (dr == DialogResult.Yes)
            {
                serialData.DebugSendFlag = true;
                serialPort.Write(Sendbuff, 0, 5);
                if (send_debug_index == 0)
                {
                    InfoBox.Text += "对应数据码是：" + "\r\n";
                }
                for (int i = 0; i < 5; i++)
                {
                    InfoBox.Text += "\'" + Convert.ToChar(Sendbuff[i]) + "\'\t ";
                }

                //让文本框获取焦点 
                this.InfoBox.Focus();
                //设置光标的位置到文本尾 
                this.InfoBox.Select(this.InfoBox.Text.Length, 0);
                //滚动到控件光标处 
                this.InfoBox.ScrollToCaret();
                Debug_Timer.Start();
            }
            else
            {
                Send_Debug_Timer.Start();
                serialData.DebugSendFlag = true;
                
            }
            
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
            byte[] Sendbuff = new byte[18];

            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
            if (CfgUartDlg.ShowDialog() != DialogResult.Cancel)
            {
                for (int i = 0; i < 6; i++)
                {
                    Sendbuff[i] = Convert.ToByte(UartData.UartInfo[i] & 0xFF);
                }
                serialPort.Write(Sendbuff, 0, 18);
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
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0xFB;
            Sendbuff[2] = 0xFF;
            Sendbuff[3] = 0xFF;
            serialPort.Write(Sendbuff, 0, 18);

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

            byte[] BytedataArray = new byte[18];
            string Hexdata = FreqDataDic[18269];
            for (int i = 0; i < 18; i++)
            {
                BytedataArray[i] = 0x00;
            }
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
            serialPort.Write(BytedataArray, 0, 18);
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
            byte[] BytedataArray = new byte[18];
            int modulePara;
            for (int i = 0; i < 18; i++)
            {
                BytedataArray[i] = 0x00;
            }
            modulePara = Convert.ToInt32(tBox_ModulePara.Text, 16);
            numOfones = Convert.ToInt16(numericUpDown_Module.Value);
            //moduledata = temp >> (32 - numOfones);

            BytedataArray[0] = 0x55;
            BytedataArray[1] = 0xEE;
            BytedataArray[2] = Convert.ToByte((modulePara >> 8) & 0xFF);
            BytedataArray[3] = Convert.ToByte((modulePara) & 0xFF);
            BytedataArray[4] = Convert.ToByte((numOfones >> 8) & 0xFF);
            BytedataArray[5] = Convert.ToByte(numOfones & 0xFF);

            serialData.DebugSendModuleFlag = true;
            serialPort.Write(BytedataArray, 0, 18);
            Module_Timer.Start();
            InfoBox.Text += "发送的调制参数是：" + modulePara.ToString() + "\r\n";
            InfoBox.Text += "发送的调制个数是：" + numOfones.ToString() + "\r\n";
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

        private void Btn_ReadTemPareByFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ConfigFileLoadDlg = new OpenFileDialog();
            

            string ConfigFileLoadPath = null;
            ConfigFileLoadDlg.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            ConfigFileLoadDlg.DefaultExt = "txt";
            ConfigFileLoadDlg.Filter = "txt File(.txt)|*.txt";
            if (ConfigFileLoadDlg.ShowDialog() == DialogResult.OK)
            {
                ConfigFileLoadPath = ConfigFileLoadDlg.FileName;
            }
            StreamReader SR = new StreamReader(ConfigFileLoadPath);
            string dataLine;//一行字符串
            string[] dataSplited;//分割后字符串数组

            char[] rnSplitChar = new char[] { '\r', '\n' };//分割符号
            char[] trnSplitChar = new char[] { '\r', '\n', '\t', ' ', ',','，'};
            double Freqdata = 0.0;
            string Hexdata = "";
            string[] HexdataArray = new string[14];

            while (!SR.EndOfStream)
            {
                dataLine = SR.ReadLine();
                if (dataLine != "")
                {
                    if (dataLine[0] == '#' && dataLine != "")
                    {
                        dataLine = dataLine.Substring(1);
                        dataSplited = dataLine.Split(trnSplitChar, StringSplitOptions.RemoveEmptyEntries);//开始分割
                        for (int i = 0; i < 3; i++)
                        {
                            temPara.d_SF_para[i] = Convert.ToDouble(dataSplited[i]);
                        }
                    }

                    if (dataLine[0] == '$' && dataLine != "")
                    {
                        dataLine = dataLine.Substring(1);
                        dataSplited = dataLine.Split(trnSplitChar, StringSplitOptions.RemoveEmptyEntries);//开始分割
                        for (int i = 0; i < 4; i++)
                        {
                            temPara.d_Bias_para[i] = Convert.ToDouble(dataSplited[i]);
                        }
                    }
                }
            }
            tBox_sfk1.Text = temPara.d_SF_para[1].ToString();
            tBox_sfk2.Text = temPara.d_SF_para[2].ToString();
            tBox_sfkn.Text = temPara.d_SF_para[0].ToString();

            tBox_BiasK1.Text = temPara.d_Bias_para[0].ToString();
            tBox_BiasK23.Text = temPara.d_Bias_para[1].ToString();
            tBox_BiasK22.Text = temPara.d_Bias_para[2].ToString();
            tBox_BiasK21.Text = temPara.d_Bias_para[3].ToString();
            SR.Close();
        }

        private void Btn_Send_TemPara_Click(object sender, EventArgs e)
        {
            try
            {

                temPara.d_Bias_para[0] = Convert.ToDouble(tBox_BiasK1.Text);
                temPara.d_Bias_para[1] = Convert.ToDouble(tBox_BiasK23.Text);
                temPara.d_Bias_para[2] = Convert.ToDouble(tBox_BiasK22.Text);
                temPara.d_Bias_para[3] = Convert.ToDouble(tBox_BiasK21.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("温补数据异常！");
                //throw;
            }

            for (int i = 0; i < 4; i++)
            {
                temPara.i_Bias_para[i] = Convert.ToInt32(temPara.d_Bias_para[i] * (i==0? 1024.0:65536.0));
                
            }
            SendBiasPara();
           

        }
        private void SendSFtemPara()
        {
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0x11;
            Sendbuff[2] = Convert.ToByte((temPara.i_SF_para[0] >> 24) & 0xFF);
            Sendbuff[3] = Convert.ToByte((temPara.i_SF_para[0] >> 16) & 0xFF);
            Sendbuff[4] = Convert.ToByte((temPara.i_SF_para[0] >> 8) & 0xFF);
            Sendbuff[5] = Convert.ToByte(temPara.i_SF_para[0] & 0xFF);
            Sendbuff[6] = Convert.ToByte((temPara.i_SF_para[1] >> 24) & 0xFF);
            Sendbuff[7] = Convert.ToByte((temPara.i_SF_para[1] >> 16) & 0xFF);
            Sendbuff[8] = Convert.ToByte((temPara.i_SF_para[1] >> 8) & 0xFF);
            Sendbuff[9] = Convert.ToByte(temPara.i_SF_para[1] & 0xFF);
            Sendbuff[10] = Convert.ToByte((temPara.i_SF_para[2] >> 24) & 0xFF);
            Sendbuff[11] = Convert.ToByte((temPara.i_SF_para[2] >> 16) & 0xFF);
            Sendbuff[12] = Convert.ToByte((temPara.i_SF_para[2] >> 8) & 0xFF);
            Sendbuff[13] = Convert.ToByte(temPara.i_SF_para[2] & 0xFF);
            serialData.DebugSendSFtemParaFlag = true;
            serialPort.Write(Sendbuff, 0, 18);
            SF_Timer.Start();
            InfoBox.Text += "发送的标度温补参数是：SF_K1 " + temPara.d_SF_para[0].ToString() + "\tSF_K2: " + temPara.d_SF_para[1].ToString() + "\r\n";
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

        private void SFtemParaTimerEventProcessor(object sender, EventArgs e)
        {
            SF_Timer.Stop();
            if (serialData.DebugSFtemParaFlag)
            {
                InfoBox.Text += "标度因数温补参数发送成功。\r\n";                
            }
            else
            {
                InfoBox.Text += "未收到标度因数参数返回信息,请确认！\r\n";
            }
            serialData.DebugSendSFtemParaFlag = false;
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }
        private void SendBiasPara()
        {
            byte[] Sendbuff = new byte[18];

            Sendbuff[0]  = 0x55;
            Sendbuff[1]  = 0x22;
            Sendbuff[2]  = Convert.ToByte((temPara.i_Bias_para[0] >> 24) & 0xFF);
            Sendbuff[3]  = Convert.ToByte((temPara.i_Bias_para[0] >> 16) & 0xFF);
            Sendbuff[4]  = Convert.ToByte((temPara.i_Bias_para[0] >> 8) & 0xFF);
            Sendbuff[5]  = Convert.ToByte(temPara.i_Bias_para[0] & 0xFF);
            Sendbuff[6]  = Convert.ToByte((temPara.i_Bias_para[1] >> 24) & 0xFF);
            Sendbuff[7]  = Convert.ToByte((temPara.i_Bias_para[1] >> 16) & 0xFF);
            Sendbuff[8]  = Convert.ToByte((temPara.i_Bias_para[1] >> 8) & 0xFF);
            Sendbuff[9]  = Convert.ToByte(temPara.i_Bias_para[1] & 0xFF);
            Sendbuff[10] = Convert.ToByte((temPara.i_Bias_para[2] >> 24) & 0xFF);
            Sendbuff[11] = Convert.ToByte((temPara.i_Bias_para[2] >> 16) & 0xFF);
            Sendbuff[12] = Convert.ToByte((temPara.i_Bias_para[2] >> 8) & 0xFF);
            Sendbuff[13] = Convert.ToByte(temPara.i_Bias_para[2] & 0xFF);
            Sendbuff[14] = Convert.ToByte((temPara.i_Bias_para[3] >> 24) & 0xFF);
            Sendbuff[15] = Convert.ToByte((temPara.i_Bias_para[3] >> 16) & 0xFF);
            Sendbuff[16] = Convert.ToByte((temPara.i_Bias_para[3] >> 8) & 0xFF);
            Sendbuff[17] = Convert.ToByte(temPara.i_Bias_para[3] & 0xFF);


            serialData.DebugSendBiastemParaFlag = true;
            serialPort.Write(Sendbuff, 0, 18);
            Bias_Timer.Start();
            InfoBox.Text += "发送的零偏温补参数是：Bias_K1 " + temPara.d_Bias_para[0].ToString() + "\tBias_K23: " + temPara.d_Bias_para[1].ToString()
                                + "\tBias_K22: " + temPara.d_Bias_para[2].ToString() + "\tBias_K21: " + temPara.d_Bias_para[3].ToString() + "\r\n";
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

        private void BiasTemParaTimerEventProcessor(object sender, EventArgs e)
        {
            Bias_Timer.Stop();
            if (serialData.DebugBiastemParaFlag)
            {
                InfoBox.Text += "零偏温补参数发送成功。\r\n";
            }
            else
            {
                InfoBox.Text += "未收零偏参数返回信息。\r\n";
            }
            serialData.DebugSendBiastemParaFlag = false;
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_TemPara_ON_Click(object sender, EventArgs e)
        {
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0x33;
            Sendbuff[2] = 0x01;
           

            serialData.DebugSendtemParaONFlag = true;
            serialPort.Write(Sendbuff, 0, 18);
            Switch_Timer.Start();
            InfoBox.Text += "发送打开温补指令\r\n";
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

        private void SwitchTimerEventProcessor(object sender, EventArgs e)
        {
            Switch_Timer.Stop();
            if (serialData.DebugSendtemParaONFlag)
            {
                if (serialData.DebugtemParaONFlag)
                {
                    InfoBox.Text += "打开温补指令发送成功。\r\n";
                }
                else
                {
                    InfoBox.Text += "未收到打开温补指令返回。\r\n";
                }
            }
            if (serialData.DebugSendtemParaOFFFlag)
            {
                if (serialData.DebugtemParaOFFFlag)
                {
                    InfoBox.Text += "关闭温补指令发送成功。\r\n";
                }
                else
                {
                    InfoBox.Text += "未收到关闭温补指令返回。\r\n";
                }
            }
            serialData.DebugSendtemParaOFFFlag = false;
            serialData.DebugSendtemParaONFlag = false;
            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
        }

        private void Btn_TemPara_OFF_Click(object sender, EventArgs e)
        {
            byte[] Sendbuff = new byte[18];
            for (int i = 0; i < 18; i++)
            {
                Sendbuff[i] = 0x00;
            }
            Sendbuff[0] = 0x55;
            Sendbuff[1] = 0x33;
            Sendbuff[2] = 0x00;


            serialData.DebugSendtemParaOFFFlag = true;
            serialPort.Write(Sendbuff, 0, 18);
            Switch_Timer.Start();
            InfoBox.Text += "发送关闭温补指令\r\n";
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

        private void Btn_SendSFPara_Click(object sender, EventArgs e)
        {
            try
            {
                temPara.d_SF_para[0] = Convert.ToDouble(tBox_sfkn.Text);
                temPara.d_SF_para[1] = Convert.ToDouble(tBox_sfk1.Text);
                temPara.d_SF_para[2] = Convert.ToDouble(tBox_sfk2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("温补数据异常！");
                //throw;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i==0)
                {
                    temPara.i_SF_para[i] = Convert.ToInt32(temPara.d_SF_para[i] * 1e12);
                }
                else
                {
                    temPara.i_SF_para[i] = Convert.ToInt32(temPara.d_SF_para[i] * 1.0e8);
                }
                
            }
            SendSFtemPara();
        }

        private void SendDebugTimerEventProcessor(object sender, EventArgs e)
        {
            byte[] Sendbuff = new byte[5];
            Sendbuff[0] = Convert.ToByte('D');
            Sendbuff[1] = Convert.ToByte('E');
            Sendbuff[2] = Convert.ToByte('B');
            Sendbuff[3] = Convert.ToByte('U');
            Sendbuff[4] = Convert.ToByte('G');

            serialPort.Write(Sendbuff, send_debug_index, 1);
            if (send_debug_index == 0)
            {
                InfoBox.Text += "对应数据码是：" + "\r\n";
            }
            
            InfoBox.Text += "\'" + Convert.ToChar(Sendbuff[send_debug_index]) + "\'\t ";


            //让文本框获取焦点 
            this.InfoBox.Focus();
            //设置光标的位置到文本尾 
            this.InfoBox.Select(this.InfoBox.Text.Length, 0);
            //滚动到控件光标处 
            this.InfoBox.ScrollToCaret();
            send_debug_index++;
            if (send_debug_index > 4)
            {
                Send_Debug_Timer.Stop();
                Debug_Timer.Start();
                send_debug_index = 0;
                InfoBox.Text += "\r\n";
            }

        }
    }
}
