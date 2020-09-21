namespace FOG_Config
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.TBox_NowFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox_UpFreq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBox_NextFreq = new System.Windows.Forms.TextBox();
            this.Btn_SerialCfg = new System.Windows.Forms.Button();
            this.Btn_OpenSerial = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.Btn_SendData = new System.Windows.Forms.Button();
            this.TBox_2pi = new System.Windows.Forms.TextBox();
            this.Btn_SendPi = new System.Windows.Forms.Button();
            this.Btn_LoopGain = new System.Windows.Forms.Button();
            this.TBOX_LoopGain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Debug = new System.Windows.Forms.Button();
            this.Btn_GyroNoInput = new System.Windows.Forms.Button();
            this.Btn_GetCfgData = new System.Windows.Forms.Button();
            this.Btn_ConfigUart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Debug_Timer = new System.Windows.Forms.Timer(this.components);
            this.Volt_Timer = new System.Windows.Forms.Timer(this.components);
            this.Loop_Timer = new System.Windows.Forms.Timer(this.components);
            this.UartCFG_Timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_FreqInex = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_ClearBox = new System.Windows.Forms.Button();
            this.numericUpDown_Module = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_ModuleData = new System.Windows.Forms.Button();
            this.Module_Timer = new System.Windows.Forms.Timer(this.components);
            this.tBox_sfk1 = new System.Windows.Forms.TextBox();
            this.tBox_sfk2 = new System.Windows.Forms.TextBox();
            this.tBox_BiasK1 = new System.Windows.Forms.TextBox();
            this.tBox_BiasK22 = new System.Windows.Forms.TextBox();
            this.tBox_BiasK21 = new System.Windows.Forms.TextBox();
            this.Btn_ReadTemPareByFile = new System.Windows.Forms.Button();
            this.Btn_Send_TemPara = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SF_Timer = new System.Windows.Forms.Timer(this.components);
            this.Bias_Timer = new System.Windows.Forms.Timer(this.components);
            this.Btn_TemPara_ON = new System.Windows.Forms.Button();
            this.Btn_TemPara_OFF = new System.Windows.Forms.Button();
            this.Switch_Timer = new System.Windows.Forms.Timer(this.components);
            this.Btn_SendSFPara = new System.Windows.Forms.Button();
            this.tBox_BiasK23 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tBox_ModulePara = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBox_sfkn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Send_Debug_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqInex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Module)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // TBox_NowFreq
            // 
            this.TBox_NowFreq.Location = new System.Drawing.Point(178, 154);
            this.TBox_NowFreq.Margin = new System.Windows.Forms.Padding(2);
            this.TBox_NowFreq.Name = "TBox_NowFreq";
            this.TBox_NowFreq.ReadOnly = true;
            this.TBox_NowFreq.Size = new System.Drawing.Size(104, 21);
            this.TBox_NowFreq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前频率值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "前一个频率值";
            // 
            // TBox_UpFreq
            // 
            this.TBox_UpFreq.Location = new System.Drawing.Point(178, 123);
            this.TBox_UpFreq.Margin = new System.Windows.Forms.Padding(2);
            this.TBox_UpFreq.Name = "TBox_UpFreq";
            this.TBox_UpFreq.ReadOnly = true;
            this.TBox_UpFreq.Size = new System.Drawing.Size(104, 21);
            this.TBox_UpFreq.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "后一个频率值";
            // 
            // TBox_NextFreq
            // 
            this.TBox_NextFreq.Location = new System.Drawing.Point(178, 190);
            this.TBox_NextFreq.Margin = new System.Windows.Forms.Padding(2);
            this.TBox_NextFreq.Name = "TBox_NextFreq";
            this.TBox_NextFreq.ReadOnly = true;
            this.TBox_NextFreq.Size = new System.Drawing.Size(104, 21);
            this.TBox_NextFreq.TabIndex = 6;
            // 
            // Btn_SerialCfg
            // 
            this.Btn_SerialCfg.Location = new System.Drawing.Point(134, 14);
            this.Btn_SerialCfg.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SerialCfg.Name = "Btn_SerialCfg";
            this.Btn_SerialCfg.Size = new System.Drawing.Size(99, 22);
            this.Btn_SerialCfg.TabIndex = 8;
            this.Btn_SerialCfg.Text = "串口配置";
            this.Btn_SerialCfg.UseVisualStyleBackColor = true;
            this.Btn_SerialCfg.Click += new System.EventHandler(this.Btn_SerialCfg_Click);
            // 
            // Btn_OpenSerial
            // 
            this.Btn_OpenSerial.Location = new System.Drawing.Point(244, 14);
            this.Btn_OpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_OpenSerial.Name = "Btn_OpenSerial";
            this.Btn_OpenSerial.Size = new System.Drawing.Size(110, 24);
            this.Btn_OpenSerial.TabIndex = 9;
            this.Btn_OpenSerial.Text = "打开串口...";
            this.Btn_OpenSerial.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial.Click += new System.EventHandler(this.Btn_OpenSerial_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(418, 13);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(263, 436);
            this.InfoBox.TabIndex = 10;
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Location = new System.Drawing.Point(14, 176);
            this.Btn_SendData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(122, 26);
            this.Btn_SendData.TabIndex = 11;
            this.Btn_SendData.Text = "发送频率点（&S）";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // TBox_2pi
            // 
            this.TBox_2pi.Location = new System.Drawing.Point(14, 269);
            this.TBox_2pi.Margin = new System.Windows.Forms.Padding(2);
            this.TBox_2pi.Name = "TBox_2pi";
            this.TBox_2pi.Size = new System.Drawing.Size(134, 21);
            this.TBox_2pi.TabIndex = 13;
            // 
            // Btn_SendPi
            // 
            this.Btn_SendPi.Location = new System.Drawing.Point(226, 266);
            this.Btn_SendPi.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SendPi.Name = "Btn_SendPi";
            this.Btn_SendPi.Size = new System.Drawing.Size(153, 26);
            this.Btn_SendPi.TabIndex = 14;
            this.Btn_SendPi.Text = "发送2π电压参数(&P)";
            this.Btn_SendPi.UseVisualStyleBackColor = true;
            this.Btn_SendPi.Click += new System.EventHandler(this.Btn_SendPi_Click);
            // 
            // Btn_LoopGain
            // 
            this.Btn_LoopGain.Location = new System.Drawing.Point(226, 303);
            this.Btn_LoopGain.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_LoopGain.Name = "Btn_LoopGain";
            this.Btn_LoopGain.Size = new System.Drawing.Size(153, 24);
            this.Btn_LoopGain.TabIndex = 16;
            this.Btn_LoopGain.Text = "发送环路增益参数(&G)";
            this.Btn_LoopGain.UseVisualStyleBackColor = true;
            this.Btn_LoopGain.Click += new System.EventHandler(this.Btn_LoopGain_Click);
            // 
            // TBOX_LoopGain
            // 
            this.TBOX_LoopGain.Location = new System.Drawing.Point(14, 306);
            this.TBOX_LoopGain.Margin = new System.Windows.Forms.Padding(2);
            this.TBOX_LoopGain.Name = "TBOX_LoopGain";
            this.TBOX_LoopGain.Size = new System.Drawing.Size(134, 21);
            this.TBOX_LoopGain.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "0~65535";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "0~65535";
            // 
            // Btn_Debug
            // 
            this.Btn_Debug.Location = new System.Drawing.Point(14, 49);
            this.Btn_Debug.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Debug.Name = "Btn_Debug";
            this.Btn_Debug.Size = new System.Drawing.Size(110, 64);
            this.Btn_Debug.TabIndex = 19;
            this.Btn_Debug.Text = "连接陀螺，进入调试模式(&D)";
            this.Btn_Debug.UseVisualStyleBackColor = true;
            this.Btn_Debug.Click += new System.EventHandler(this.Btn_Debug_Click);
            // 
            // Btn_GyroNoInput
            // 
            this.Btn_GyroNoInput.Location = new System.Drawing.Point(14, 14);
            this.Btn_GyroNoInput.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_GyroNoInput.Name = "Btn_GyroNoInput";
            this.Btn_GyroNoInput.Size = new System.Drawing.Size(102, 23);
            this.Btn_GyroNoInput.TabIndex = 20;
            this.Btn_GyroNoInput.Text = "陀螺型号设置";
            this.Btn_GyroNoInput.UseVisualStyleBackColor = true;
            this.Btn_GyroNoInput.Click += new System.EventHandler(this.Btn_GyroNoInput_Click);
            // 
            // Btn_GetCfgData
            // 
            this.Btn_GetCfgData.Location = new System.Drawing.Point(134, 49);
            this.Btn_GetCfgData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_GetCfgData.Name = "Btn_GetCfgData";
            this.Btn_GetCfgData.Size = new System.Drawing.Size(106, 24);
            this.Btn_GetCfgData.TabIndex = 21;
            this.Btn_GetCfgData.Text = "读取配置数据";
            this.Btn_GetCfgData.UseVisualStyleBackColor = true;
            this.Btn_GetCfgData.Click += new System.EventHandler(this.Btn_GetCfgData_Click);
            // 
            // Btn_ConfigUart
            // 
            this.Btn_ConfigUart.Location = new System.Drawing.Point(254, 49);
            this.Btn_ConfigUart.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ConfigUart.Name = "Btn_ConfigUart";
            this.Btn_ConfigUart.Size = new System.Drawing.Size(99, 23);
            this.Btn_ConfigUart.TabIndex = 22;
            this.Btn_ConfigUart.Text = "配置通讯协议";
            this.Btn_ConfigUart.UseVisualStyleBackColor = true;
            this.Btn_ConfigUart.Click += new System.EventHandler(this.Btn_ConfigUart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "2π电压参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "环路增益参数";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(134, 86);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(219, 26);
            this.Btn_Reset.TabIndex = 24;
            this.Btn_Reset.Text = "还原出厂设置";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Debug_Timer
            // 
            this.Debug_Timer.Interval = 2000;
            this.Debug_Timer.Tick += new System.EventHandler(this.TimerEventProcessor);
            // 
            // Volt_Timer
            // 
            this.Volt_Timer.Interval = 1000;
            this.Volt_Timer.Tick += new System.EventHandler(this.VoltTimerEventProcessor);
            // 
            // Loop_Timer
            // 
            this.Loop_Timer.Interval = 1000;
            this.Loop_Timer.Tick += new System.EventHandler(this.LoopTimerEventProcessor);
            // 
            // UartCFG_Timer
            // 
            this.UartCFG_Timer.Interval = 1000;
            this.UartCFG_Timer.Tick += new System.EventHandler(this.UartCfgTimerEventProcessor);
            // 
            // numericUpDown_FreqInex
            // 
            this.numericUpDown_FreqInex.Location = new System.Drawing.Point(16, 144);
            this.numericUpDown_FreqInex.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FreqInex.Maximum = new decimal(new int[] {
            157,
            0,
            0,
            0});
            this.numericUpDown_FreqInex.Name = "numericUpDown_FreqInex";
            this.numericUpDown_FreqInex.Size = new System.Drawing.Size(107, 21);
            this.numericUpDown_FreqInex.TabIndex = 25;
            this.numericUpDown_FreqInex.Value = new decimal(new int[] {
            87,
            0,
            0,
            0});
            this.numericUpDown_FreqInex.ValueChanged += new System.EventHandler(this.numericUpDown_FreqInex_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "频率编号（0~157）";
            // 
            // Btn_ClearBox
            // 
            this.Btn_ClearBox.Location = new System.Drawing.Point(323, 228);
            this.Btn_ClearBox.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ClearBox.Name = "Btn_ClearBox";
            this.Btn_ClearBox.Size = new System.Drawing.Size(90, 26);
            this.Btn_ClearBox.TabIndex = 27;
            this.Btn_ClearBox.Text = "清除显示文本";
            this.Btn_ClearBox.UseVisualStyleBackColor = true;
            this.Btn_ClearBox.Click += new System.EventHandler(this.Btn_ClearBox_Click);
            // 
            // numericUpDown_Module
            // 
            this.numericUpDown_Module.Location = new System.Drawing.Point(14, 228);
            this.numericUpDown_Module.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Module.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_Module.Name = "numericUpDown_Module";
            this.numericUpDown_Module.Size = new System.Drawing.Size(63, 21);
            this.numericUpDown_Module.TabIndex = 28;
            this.numericUpDown_Module.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "1的个数(0~64）";
            // 
            // Btn_ModuleData
            // 
            this.Btn_ModuleData.Location = new System.Drawing.Point(226, 228);
            this.Btn_ModuleData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModuleData.Name = "Btn_ModuleData";
            this.Btn_ModuleData.Size = new System.Drawing.Size(92, 26);
            this.Btn_ModuleData.TabIndex = 30;
            this.Btn_ModuleData.Text = "发送调制参数";
            this.Btn_ModuleData.UseVisualStyleBackColor = true;
            this.Btn_ModuleData.Click += new System.EventHandler(this.Btn_ModuleData_Click);
            // 
            // Module_Timer
            // 
            this.Module_Timer.Interval = 1000;
            this.Module_Timer.Tick += new System.EventHandler(this.ModuleTimerEventProcessor);
            // 
            // tBox_sfk1
            // 
            this.tBox_sfk1.Location = new System.Drawing.Point(12, 383);
            this.tBox_sfk1.Name = "tBox_sfk1";
            this.tBox_sfk1.Size = new System.Drawing.Size(87, 21);
            this.tBox_sfk1.TabIndex = 31;
            // 
            // tBox_sfk2
            // 
            this.tBox_sfk2.Location = new System.Drawing.Point(105, 383);
            this.tBox_sfk2.Name = "tBox_sfk2";
            this.tBox_sfk2.Size = new System.Drawing.Size(87, 21);
            this.tBox_sfk2.TabIndex = 32;
            // 
            // tBox_BiasK1
            // 
            this.tBox_BiasK1.Location = new System.Drawing.Point(12, 428);
            this.tBox_BiasK1.Name = "tBox_BiasK1";
            this.tBox_BiasK1.Size = new System.Drawing.Size(65, 21);
            this.tBox_BiasK1.TabIndex = 33;
            // 
            // tBox_BiasK22
            // 
            this.tBox_BiasK22.Location = new System.Drawing.Point(166, 428);
            this.tBox_BiasK22.Name = "tBox_BiasK22";
            this.tBox_BiasK22.Size = new System.Drawing.Size(65, 21);
            this.tBox_BiasK22.TabIndex = 34;
            // 
            // tBox_BiasK21
            // 
            this.tBox_BiasK21.Location = new System.Drawing.Point(243, 428);
            this.tBox_BiasK21.Name = "tBox_BiasK21";
            this.tBox_BiasK21.Size = new System.Drawing.Size(65, 21);
            this.tBox_BiasK21.TabIndex = 35;
            // 
            // Btn_ReadTemPareByFile
            // 
            this.Btn_ReadTemPareByFile.Location = new System.Drawing.Point(197, 344);
            this.Btn_ReadTemPareByFile.Name = "Btn_ReadTemPareByFile";
            this.Btn_ReadTemPareByFile.Size = new System.Drawing.Size(107, 23);
            this.Btn_ReadTemPareByFile.TabIndex = 36;
            this.Btn_ReadTemPareByFile.Text = "从文件读取参数...";
            this.Btn_ReadTemPareByFile.UseVisualStyleBackColor = true;
            this.Btn_ReadTemPareByFile.Click += new System.EventHandler(this.Btn_ReadTemPareByFile_Click);
            // 
            // Btn_Send_TemPara
            // 
            this.Btn_Send_TemPara.Location = new System.Drawing.Point(319, 428);
            this.Btn_Send_TemPara.Name = "Btn_Send_TemPara";
            this.Btn_Send_TemPara.Size = new System.Drawing.Size(94, 20);
            this.Btn_Send_TemPara.TabIndex = 37;
            this.Btn_Send_TemPara.Text = "发送零偏参数";
            this.Btn_Send_TemPara.UseVisualStyleBackColor = true;
            this.Btn_Send_TemPara.Click += new System.EventHandler(this.Btn_Send_TemPara_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "SF_K1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 39;
            this.label11.Text = "SF_K2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "Bias_K1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "Bias_K22";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(242, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 42;
            this.label14.Text = "Bias_K21";
            // 
            // SF_Timer
            // 
            this.SF_Timer.Interval = 1000;
            this.SF_Timer.Tick += new System.EventHandler(this.SFtemParaTimerEventProcessor);
            // 
            // Bias_Timer
            // 
            this.Bias_Timer.Interval = 1000;
            this.Bias_Timer.Tick += new System.EventHandler(this.BiasTemParaTimerEventProcessor);
            // 
            // Btn_TemPara_ON
            // 
            this.Btn_TemPara_ON.Location = new System.Drawing.Point(319, 344);
            this.Btn_TemPara_ON.Name = "Btn_TemPara_ON";
            this.Btn_TemPara_ON.Size = new System.Drawing.Size(94, 23);
            this.Btn_TemPara_ON.TabIndex = 43;
            this.Btn_TemPara_ON.Text = "打开温度补偿";
            this.Btn_TemPara_ON.UseVisualStyleBackColor = true;
            this.Btn_TemPara_ON.Click += new System.EventHandler(this.Btn_TemPara_ON_Click);
            // 
            // Btn_TemPara_OFF
            // 
            this.Btn_TemPara_OFF.Location = new System.Drawing.Point(319, 382);
            this.Btn_TemPara_OFF.Name = "Btn_TemPara_OFF";
            this.Btn_TemPara_OFF.Size = new System.Drawing.Size(94, 23);
            this.Btn_TemPara_OFF.TabIndex = 44;
            this.Btn_TemPara_OFF.Text = "关闭温度补偿";
            this.Btn_TemPara_OFF.UseVisualStyleBackColor = true;
            this.Btn_TemPara_OFF.Click += new System.EventHandler(this.Btn_TemPara_OFF_Click);
            // 
            // Switch_Timer
            // 
            this.Switch_Timer.Interval = 1000;
            this.Switch_Timer.Tick += new System.EventHandler(this.SwitchTimerEventProcessor);
            // 
            // Btn_SendSFPara
            // 
            this.Btn_SendSFPara.Location = new System.Drawing.Point(197, 382);
            this.Btn_SendSFPara.Name = "Btn_SendSFPara";
            this.Btn_SendSFPara.Size = new System.Drawing.Size(107, 23);
            this.Btn_SendSFPara.TabIndex = 45;
            this.Btn_SendSFPara.Text = "发送标度参数";
            this.Btn_SendSFPara.UseVisualStyleBackColor = true;
            this.Btn_SendSFPara.Click += new System.EventHandler(this.Btn_SendSFPara_Click);
            // 
            // tBox_BiasK23
            // 
            this.tBox_BiasK23.Location = new System.Drawing.Point(89, 428);
            this.tBox_BiasK23.Name = "tBox_BiasK23";
            this.tBox_BiasK23.Size = new System.Drawing.Size(65, 21);
            this.tBox_BiasK23.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 47;
            this.label15.Text = "Bias_K23";
            // 
            // tBox_ModulePara
            // 
            this.tBox_ModulePara.Location = new System.Drawing.Point(120, 227);
            this.tBox_ModulePara.Name = "tBox_ModulePara";
            this.tBox_ModulePara.Size = new System.Drawing.Size(87, 21);
            this.tBox_ModulePara.TabIndex = 48;
            this.tBox_ModulePara.Text = "200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 212);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "调制参数";
            // 
            // tBox_sfkn
            // 
            this.tBox_sfkn.Location = new System.Drawing.Point(53, 344);
            this.tBox_sfkn.Name = "tBox_sfkn";
            this.tBox_sfkn.Size = new System.Drawing.Size(100, 21);
            this.tBox_sfkn.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 51;
            this.label17.Text = "SF_Kn";
            // 
            // Send_Debug_Timer
            // 
            this.Send_Debug_Timer.Interval = 10;
            this.Send_Debug_Timer.Tick += new System.EventHandler(this.SendDebugTimerEventProcessor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 460);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tBox_sfkn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tBox_ModulePara);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tBox_BiasK23);
            this.Controls.Add(this.Btn_SendSFPara);
            this.Controls.Add(this.Btn_TemPara_OFF);
            this.Controls.Add(this.Btn_TemPara_ON);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btn_Send_TemPara);
            this.Controls.Add(this.Btn_ReadTemPareByFile);
            this.Controls.Add(this.tBox_BiasK21);
            this.Controls.Add(this.tBox_BiasK22);
            this.Controls.Add(this.tBox_BiasK1);
            this.Controls.Add(this.tBox_sfk2);
            this.Controls.Add(this.tBox_sfk1);
            this.Controls.Add(this.Btn_ModuleData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown_Module);
            this.Controls.Add(this.Btn_ClearBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_FreqInex);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_ConfigUart);
            this.Controls.Add(this.Btn_GetCfgData);
            this.Controls.Add(this.Btn_GyroNoInput);
            this.Controls.Add(this.Btn_Debug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_LoopGain);
            this.Controls.Add(this.TBOX_LoopGain);
            this.Controls.Add(this.Btn_SendPi);
            this.Controls.Add(this.TBox_2pi);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.Btn_OpenSerial);
            this.Controls.Add(this.Btn_SerialCfg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBox_NextFreq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox_UpFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBox_NowFreq);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "陀螺调试助手";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqInex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Module)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox TBox_NowFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBox_UpFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBox_NextFreq;
        private System.Windows.Forms.Button Btn_SerialCfg;
        private System.Windows.Forms.Button Btn_OpenSerial;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.Button Btn_SendData;
        private System.Windows.Forms.TextBox TBox_2pi;
        private System.Windows.Forms.Button Btn_SendPi;
        private System.Windows.Forms.Button Btn_LoopGain;
        private System.Windows.Forms.TextBox TBOX_LoopGain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Debug;
        private System.Windows.Forms.Button Btn_GyroNoInput;
        private System.Windows.Forms.Button Btn_GetCfgData;
        private System.Windows.Forms.Button Btn_ConfigUart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Timer Debug_Timer;
        private System.Windows.Forms.Timer Volt_Timer;
        private System.Windows.Forms.Timer Loop_Timer;
        private System.Windows.Forms.Timer UartCFG_Timer;
        private System.Windows.Forms.NumericUpDown numericUpDown_FreqInex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_ClearBox;
        private System.Windows.Forms.NumericUpDown numericUpDown_Module;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_ModuleData;
        private System.Windows.Forms.Timer Module_Timer;
        private System.Windows.Forms.TextBox tBox_sfk1;
        private System.Windows.Forms.TextBox tBox_sfk2;
        private System.Windows.Forms.TextBox tBox_BiasK1;
        private System.Windows.Forms.TextBox tBox_BiasK22;
        private System.Windows.Forms.TextBox tBox_BiasK21;
        private System.Windows.Forms.Button Btn_ReadTemPareByFile;
        private System.Windows.Forms.Button Btn_Send_TemPara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer SF_Timer;
        private System.Windows.Forms.Timer Bias_Timer;
        private System.Windows.Forms.Button Btn_TemPara_ON;
        private System.Windows.Forms.Button Btn_TemPara_OFF;
        private System.Windows.Forms.Timer Switch_Timer;
        private System.Windows.Forms.Button Btn_SendSFPara;
        private System.Windows.Forms.TextBox tBox_BiasK23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBox_ModulePara;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBox_sfkn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer Send_Debug_Timer;
    }
}

