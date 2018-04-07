namespace FOG_Config
{
    partial class FrmSerialCfg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.cmbox_SerialNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbox__DataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_ParityBit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_OK
            // 
            this.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OK.Location = new System.Drawing.Point(270, 72);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(107, 38);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.Text = "确定(&O)";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(270, 170);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(107, 38);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "取消(&C)";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // cmbox_SerialNum
            // 
            this.cmbox_SerialNum.FormattingEnabled = true;
            this.cmbox_SerialNum.Location = new System.Drawing.Point(100, 38);
            this.cmbox_SerialNum.Name = "cmbox_SerialNum";
            this.cmbox_SerialNum.Size = new System.Drawing.Size(111, 29);
            this.cmbox_SerialNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率";
            // 
            // cmbox_BaudRate
            // 
            this.cmbox_BaudRate.FormattingEnabled = true;
            this.cmbox_BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "115200",
            "230400",
            "460800",
            "614400",
            "921600"});
            this.cmbox_BaudRate.Location = new System.Drawing.Point(100, 87);
            this.cmbox_BaudRate.Name = "cmbox_BaudRate";
            this.cmbox_BaudRate.Size = new System.Drawing.Size(111, 29);
            this.cmbox_BaudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位";
            // 
            // cmbox__DataBit
            // 
            this.cmbox__DataBit.FormattingEnabled = true;
            this.cmbox__DataBit.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbox__DataBit.Location = new System.Drawing.Point(100, 136);
            this.cmbox__DataBit.Name = "cmbox__DataBit";
            this.cmbox__DataBit.Size = new System.Drawing.Size(111, 29);
            this.cmbox__DataBit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "停止位";
            // 
            // cmbox_StopBit
            // 
            this.cmbox_StopBit.FormattingEnabled = true;
            this.cmbox_StopBit.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2"});
            this.cmbox_StopBit.Location = new System.Drawing.Point(100, 185);
            this.cmbox_StopBit.Name = "cmbox_StopBit";
            this.cmbox_StopBit.Size = new System.Drawing.Size(111, 29);
            this.cmbox_StopBit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "校验位";
            // 
            // cmbox_ParityBit
            // 
            this.cmbox_ParityBit.FormattingEnabled = true;
            this.cmbox_ParityBit.Items.AddRange(new object[] {
            "odd",
            "none",
            "even"});
            this.cmbox_ParityBit.Location = new System.Drawing.Point(100, 234);
            this.cmbox_ParityBit.Name = "cmbox_ParityBit";
            this.cmbox_ParityBit.Size = new System.Drawing.Size(111, 29);
            this.cmbox_ParityBit.TabIndex = 10;
            // 
            // FrmSerialCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbox_ParityBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_StopBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbox__DataBit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_BaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_SerialNum);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Name = "FrmSerialCfg";
            this.Text = "串口配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ComboBox cmbox_SerialNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbox__DataBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_ParityBit;
    }
}