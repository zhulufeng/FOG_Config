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
            this.TBox_NowFreq.Location = new System.Drawing.Point(356, 307);
            this.TBox_NowFreq.Name = "TBox_NowFreq";
            this.TBox_NowFreq.ReadOnly = true;
            this.TBox_NowFreq.Size = new System.Drawing.Size(205, 35);
            this.TBox_NowFreq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前频率值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "前一个频率值";
            // 
            // TBox_UpFreq
            // 
            this.TBox_UpFreq.Location = new System.Drawing.Point(356, 246);
            this.TBox_UpFreq.Name = "TBox_UpFreq";
            this.TBox_UpFreq.ReadOnly = true;
            this.TBox_UpFreq.Size = new System.Drawing.Size(205, 35);
            this.TBox_UpFreq.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "后一个频率值";
            // 
            // TBox_NextFreq
            // 
            this.TBox_NextFreq.Location = new System.Drawing.Point(356, 379);
            this.TBox_NextFreq.Name = "TBox_NextFreq";
            this.TBox_NextFreq.ReadOnly = true;
            this.TBox_NextFreq.Size = new System.Drawing.Size(205, 35);
            this.TBox_NextFreq.TabIndex = 6;
            // 
            // Btn_SerialCfg
            // 
            this.Btn_SerialCfg.Location = new System.Drawing.Point(268, 28);
            this.Btn_SerialCfg.Name = "Btn_SerialCfg";
            this.Btn_SerialCfg.Size = new System.Drawing.Size(198, 45);
            this.Btn_SerialCfg.TabIndex = 8;
            this.Btn_SerialCfg.Text = "串口配置";
            this.Btn_SerialCfg.UseVisualStyleBackColor = true;
            this.Btn_SerialCfg.Click += new System.EventHandler(this.Btn_SerialCfg_Click);
            // 
            // Btn_OpenSerial
            // 
            this.Btn_OpenSerial.Location = new System.Drawing.Point(488, 28);
            this.Btn_OpenSerial.Name = "Btn_OpenSerial";
            this.Btn_OpenSerial.Size = new System.Drawing.Size(219, 49);
            this.Btn_OpenSerial.TabIndex = 9;
            this.Btn_OpenSerial.Text = "打开串口...";
            this.Btn_OpenSerial.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial.Click += new System.EventHandler(this.Btn_OpenSerial_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(795, 28);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(448, 630);
            this.InfoBox.TabIndex = 10;
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Location = new System.Drawing.Point(28, 353);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(244, 53);
            this.Btn_SendData.TabIndex = 11;
            this.Btn_SendData.Text = "发送频率点（&S）";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // TBox_2pi
            // 
            this.TBox_2pi.Location = new System.Drawing.Point(28, 547);
            this.TBox_2pi.Name = "TBox_2pi";
            this.TBox_2pi.Size = new System.Drawing.Size(265, 35);
            this.TBox_2pi.TabIndex = 13;
            // 
            // Btn_SendPi
            // 
            this.Btn_SendPi.Location = new System.Drawing.Point(451, 531);
            this.Btn_SendPi.Name = "Btn_SendPi";
            this.Btn_SendPi.Size = new System.Drawing.Size(306, 51);
            this.Btn_SendPi.TabIndex = 14;
            this.Btn_SendPi.Text = "发送2π电压参数(&P)";
            this.Btn_SendPi.UseVisualStyleBackColor = true;
            this.Btn_SendPi.Click += new System.EventHandler(this.Btn_SendPi_Click);
            // 
            // Btn_LoopGain
            // 
            this.Btn_LoopGain.Location = new System.Drawing.Point(451, 615);
            this.Btn_LoopGain.Name = "Btn_LoopGain";
            this.Btn_LoopGain.Size = new System.Drawing.Size(306, 47);
            this.Btn_LoopGain.TabIndex = 16;
            this.Btn_LoopGain.Text = "发送环路增益参数(&G)";
            this.Btn_LoopGain.UseVisualStyleBackColor = true;
            this.Btn_LoopGain.Click += new System.EventHandler(this.Btn_LoopGain_Click);
            // 
            // TBOX_LoopGain
            // 
            this.TBOX_LoopGain.Location = new System.Drawing.Point(28, 623);
            this.TBOX_LoopGain.Name = "TBOX_LoopGain";
            this.TBOX_LoopGain.Size = new System.Drawing.Size(265, 35);
            this.TBOX_LoopGain.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "0~65535";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "0~65535";
            // 
            // Btn_Debug
            // 
            this.Btn_Debug.Location = new System.Drawing.Point(28, 98);
            this.Btn_Debug.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Debug.Name = "Btn_Debug";
            this.Btn_Debug.Size = new System.Drawing.Size(219, 128);
            this.Btn_Debug.TabIndex = 19;
            this.Btn_Debug.Text = "连接陀螺，进入调试模式(&D)";
            this.Btn_Debug.UseVisualStyleBackColor = true;
            this.Btn_Debug.Click += new System.EventHandler(this.Btn_Debug_Click);
            // 
            // Btn_GyroNoInput
            // 
            this.Btn_GyroNoInput.Location = new System.Drawing.Point(28, 27);
            this.Btn_GyroNoInput.Name = "Btn_GyroNoInput";
            this.Btn_GyroNoInput.Size = new System.Drawing.Size(204, 46);
            this.Btn_GyroNoInput.TabIndex = 20;
            this.Btn_GyroNoInput.Text = "陀螺型号设置";
            this.Btn_GyroNoInput.UseVisualStyleBackColor = true;
            this.Btn_GyroNoInput.Click += new System.EventHandler(this.Btn_GyroNoInput_Click);
            // 
            // Btn_GetCfgData
            // 
            this.Btn_GetCfgData.Location = new System.Drawing.Point(268, 98);
            this.Btn_GetCfgData.Name = "Btn_GetCfgData";
            this.Btn_GetCfgData.Size = new System.Drawing.Size(213, 49);
            this.Btn_GetCfgData.TabIndex = 21;
            this.Btn_GetCfgData.Text = "读取配置数据";
            this.Btn_GetCfgData.UseVisualStyleBackColor = true;
            this.Btn_GetCfgData.Click += new System.EventHandler(this.Btn_GetCfgData_Click);
            // 
            // Btn_ConfigUart
            // 
            this.Btn_ConfigUart.Location = new System.Drawing.Point(508, 98);
            this.Btn_ConfigUart.Name = "Btn_ConfigUart";
            this.Btn_ConfigUart.Size = new System.Drawing.Size(198, 46);
            this.Btn_ConfigUart.TabIndex = 22;
            this.Btn_ConfigUart.Text = "配置通讯协议";
            this.Btn_ConfigUart.UseVisualStyleBackColor = true;
            this.Btn_ConfigUart.Click += new System.EventHandler(this.Btn_ConfigUart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "2π电压参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "环路增益参数";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(268, 173);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(438, 53);
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
            this.numericUpDown_FreqInex.Location = new System.Drawing.Point(33, 288);
            this.numericUpDown_FreqInex.Maximum = new decimal(new int[] {
            157,
            0,
            0,
            0});
            this.numericUpDown_FreqInex.Name = "numericUpDown_FreqInex";
            this.numericUpDown_FreqInex.Size = new System.Drawing.Size(214, 35);
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
            this.label8.Location = new System.Drawing.Point(33, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "频率编号（0~157）";
            // 
            // Btn_ClearBox
            // 
            this.Btn_ClearBox.Location = new System.Drawing.Point(591, 456);
            this.Btn_ClearBox.Name = "Btn_ClearBox";
            this.Btn_ClearBox.Size = new System.Drawing.Size(181, 53);
            this.Btn_ClearBox.TabIndex = 27;
            this.Btn_ClearBox.Text = "清除显示文本";
            this.Btn_ClearBox.UseVisualStyleBackColor = true;
            this.Btn_ClearBox.Click += new System.EventHandler(this.Btn_ClearBox_Click);
            // 
            // numericUpDown_Module
            // 
            this.numericUpDown_Module.Location = new System.Drawing.Point(28, 456);
            this.numericUpDown_Module.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDown_Module.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Module.Name = "numericUpDown_Module";
            this.numericUpDown_Module.Size = new System.Drawing.Size(227, 35);
            this.numericUpDown_Module.TabIndex = 28;
            this.numericUpDown_Module.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "调制参数（1的个数10~22）";
            // 
            // Btn_ModuleData
            // 
            this.Btn_ModuleData.Location = new System.Drawing.Point(325, 453);
            this.Btn_ModuleData.Name = "Btn_ModuleData";
            this.Btn_ModuleData.Size = new System.Drawing.Size(185, 53);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 757);
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
    }
}

