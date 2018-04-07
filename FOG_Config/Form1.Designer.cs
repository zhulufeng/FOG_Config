﻿namespace FOG_Config
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
            this.Btn_SendUp = new System.Windows.Forms.Button();
            this.Btn_SendDown = new System.Windows.Forms.Button();
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
            this.Btn_CustomFreq = new System.Windows.Forms.Button();
            this.TBox_2pi = new System.Windows.Forms.TextBox();
            this.Btn_SendPi = new System.Windows.Forms.Button();
            this.Btn_LoopGain = new System.Windows.Forms.Button();
            this.TBOX_LoopGain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Btn_SendUp
            // 
            this.Btn_SendUp.Location = new System.Drawing.Point(36, 249);
            this.Btn_SendUp.Name = "Btn_SendUp";
            this.Btn_SendUp.Size = new System.Drawing.Size(214, 44);
            this.Btn_SendUp.TabIndex = 0;
            this.Btn_SendUp.Text = "上一个频率点(&U)";
            this.Btn_SendUp.UseVisualStyleBackColor = true;
            this.Btn_SendUp.Click += new System.EventHandler(this.Btn_SendUp_Click);
            // 
            // Btn_SendDown
            // 
            this.Btn_SendDown.Location = new System.Drawing.Point(36, 326);
            this.Btn_SendDown.Name = "Btn_SendDown";
            this.Btn_SendDown.Size = new System.Drawing.Size(214, 44);
            this.Btn_SendDown.TabIndex = 1;
            this.Btn_SendDown.Text = "下一个频率点(&D)";
            this.Btn_SendDown.UseVisualStyleBackColor = true;
            this.Btn_SendDown.Click += new System.EventHandler(this.Btn_SendDown_Click);
            // 
            // TBox_NowFreq
            // 
            this.TBox_NowFreq.Location = new System.Drawing.Point(360, 317);
            this.TBox_NowFreq.Name = "TBox_NowFreq";
            this.TBox_NowFreq.Size = new System.Drawing.Size(265, 35);
            this.TBox_NowFreq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前频率值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "前一个频率值";
            // 
            // TBox_UpFreq
            // 
            this.TBox_UpFreq.Location = new System.Drawing.Point(360, 258);
            this.TBox_UpFreq.Name = "TBox_UpFreq";
            this.TBox_UpFreq.Size = new System.Drawing.Size(265, 35);
            this.TBox_UpFreq.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "后一个频率值";
            // 
            // TBox_NextFreq
            // 
            this.TBox_NextFreq.Location = new System.Drawing.Point(360, 381);
            this.TBox_NextFreq.Name = "TBox_NextFreq";
            this.TBox_NextFreq.Size = new System.Drawing.Size(265, 35);
            this.TBox_NextFreq.TabIndex = 6;
            // 
            // Btn_SerialCfg
            // 
            this.Btn_SerialCfg.Location = new System.Drawing.Point(45, 44);
            this.Btn_SerialCfg.Name = "Btn_SerialCfg";
            this.Btn_SerialCfg.Size = new System.Drawing.Size(161, 46);
            this.Btn_SerialCfg.TabIndex = 8;
            this.Btn_SerialCfg.Text = "串口配置";
            this.Btn_SerialCfg.UseVisualStyleBackColor = true;
            this.Btn_SerialCfg.Click += new System.EventHandler(this.Btn_SerialCfg_Click);
            // 
            // Btn_OpenSerial
            // 
            this.Btn_OpenSerial.Location = new System.Drawing.Point(45, 118);
            this.Btn_OpenSerial.Name = "Btn_OpenSerial";
            this.Btn_OpenSerial.Size = new System.Drawing.Size(161, 49);
            this.Btn_OpenSerial.TabIndex = 9;
            this.Btn_OpenSerial.Text = "打开串口...";
            this.Btn_OpenSerial.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial.Click += new System.EventHandler(this.Btn_OpenSerial_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(360, 33);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(401, 188);
            this.InfoBox.TabIndex = 10;
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Location = new System.Drawing.Point(36, 464);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(214, 46);
            this.Btn_SendData.TabIndex = 11;
            this.Btn_SendData.Text = "发送（&S）";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // Btn_CustomFreq
            // 
            this.Btn_CustomFreq.Location = new System.Drawing.Point(36, 392);
            this.Btn_CustomFreq.Name = "Btn_CustomFreq";
            this.Btn_CustomFreq.Size = new System.Drawing.Size(219, 46);
            this.Btn_CustomFreq.TabIndex = 12;
            this.Btn_CustomFreq.Text = "自定义...(&C)";
            this.Btn_CustomFreq.UseVisualStyleBackColor = true;
            this.Btn_CustomFreq.Click += new System.EventHandler(this.Btn_CustomFreq_Click);
            // 
            // TBox_2pi
            // 
            this.TBox_2pi.Location = new System.Drawing.Point(360, 464);
            this.TBox_2pi.Name = "TBox_2pi";
            this.TBox_2pi.Size = new System.Drawing.Size(265, 35);
            this.TBox_2pi.TabIndex = 13;
            // 
            // Btn_SendPi
            // 
            this.Btn_SendPi.Location = new System.Drawing.Point(639, 439);
            this.Btn_SendPi.Name = "Btn_SendPi";
            this.Btn_SendPi.Size = new System.Drawing.Size(146, 71);
            this.Btn_SendPi.TabIndex = 14;
            this.Btn_SendPi.Text = "发送2π电压参数(&P)";
            this.Btn_SendPi.UseVisualStyleBackColor = true;
            this.Btn_SendPi.Click += new System.EventHandler(this.Btn_SendPi_Click);
            // 
            // Btn_LoopGain
            // 
            this.Btn_LoopGain.Location = new System.Drawing.Point(639, 536);
            this.Btn_LoopGain.Name = "Btn_LoopGain";
            this.Btn_LoopGain.Size = new System.Drawing.Size(146, 71);
            this.Btn_LoopGain.TabIndex = 16;
            this.Btn_LoopGain.Text = "发送环路增益参数(&G)";
            this.Btn_LoopGain.UseVisualStyleBackColor = true;
            this.Btn_LoopGain.Click += new System.EventHandler(this.Btn_LoopGain_Click);
            // 
            // TBOX_LoopGain
            // 
            this.TBOX_LoopGain.Location = new System.Drawing.Point(360, 544);
            this.TBOX_LoopGain.Name = "TBOX_LoopGain";
            this.TBOX_LoopGain.Size = new System.Drawing.Size(265, 35);
            this.TBOX_LoopGain.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "0~65535";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "0~65535";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_LoopGain);
            this.Controls.Add(this.TBOX_LoopGain);
            this.Controls.Add(this.Btn_SendPi);
            this.Controls.Add(this.TBox_2pi);
            this.Controls.Add(this.Btn_CustomFreq);
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
            this.Controls.Add(this.Btn_SendDown);
            this.Controls.Add(this.Btn_SendUp);
            this.Name = "Form1";
            this.Text = "陀螺调试助手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button Btn_SendUp;
        private System.Windows.Forms.Button Btn_SendDown;
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
        private System.Windows.Forms.Button Btn_CustomFreq;
        private System.Windows.Forms.TextBox TBox_2pi;
        private System.Windows.Forms.Button Btn_SendPi;
        private System.Windows.Forms.Button Btn_LoopGain;
        private System.Windows.Forms.TextBox TBOX_LoopGain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

