namespace FOG_Config
{
    partial class FrmConfigUart
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
            this.groupBox_Trigger = new System.Windows.Forms.GroupBox();
            this.rBtn_Trigger_mangfa = new System.Windows.Forms.RadioButton();
            this.rBtn_Trigger_woshou = new System.Windows.Forms.RadioButton();
            this.groupBox_protocol = new System.Windows.Forms.GroupBox();
            this.rbtn_protocol_buaa = new System.Windows.Forms.RadioButton();
            this.rBtn_protocol_180908 = new System.Windows.Forms.RadioButton();
            this.rBtn_protocol_rainbow = new System.Windows.Forms.RadioButton();
            this.rBtn_protocol_reserve = new System.Windows.Forms.RadioButton();
            this.groupBox_Baud = new System.Windows.Forms.GroupBox();
            this.rBtn_Baud_115 = new System.Windows.Forms.RadioButton();
            this.rBtn_Baud_460 = new System.Windows.Forms.RadioButton();
            this.groupBox_Upd = new System.Windows.Forms.GroupBox();
            this.rBtn_Upd_1000 = new System.Windows.Forms.RadioButton();
            this.rBtn_Upd_400 = new System.Windows.Forms.RadioButton();
            this.rBtn_Upd_woshou = new System.Windows.Forms.RadioButton();
            this.rBtn_Upd_2000 = new System.Windows.Forms.RadioButton();
            this.rBtn_Baud_614 = new System.Windows.Forms.RadioButton();
            this.groupBox_Trigger.SuspendLayout();
            this.groupBox_protocol.SuspendLayout();
            this.groupBox_Baud.SuspendLayout();
            this.groupBox_Upd.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OK
            // 
            this.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OK.Location = new System.Drawing.Point(43, 222);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(76, 21);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "确认";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(228, 222);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(79, 21);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox_Trigger
            // 
            this.groupBox_Trigger.Controls.Add(this.rBtn_Trigger_mangfa);
            this.groupBox_Trigger.Controls.Add(this.rBtn_Trigger_woshou);
            this.groupBox_Trigger.Location = new System.Drawing.Point(36, 17);
            this.groupBox_Trigger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Trigger.Name = "groupBox_Trigger";
            this.groupBox_Trigger.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Trigger.Size = new System.Drawing.Size(91, 72);
            this.groupBox_Trigger.TabIndex = 7;
            this.groupBox_Trigger.TabStop = false;
            this.groupBox_Trigger.Text = " 触发方式";
            // 
            // rBtn_Trigger_mangfa
            // 
            this.rBtn_Trigger_mangfa.AutoSize = true;
            this.rBtn_Trigger_mangfa.Location = new System.Drawing.Point(4, 44);
            this.rBtn_Trigger_mangfa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Trigger_mangfa.Name = "rBtn_Trigger_mangfa";
            this.rBtn_Trigger_mangfa.Size = new System.Drawing.Size(47, 16);
            this.rBtn_Trigger_mangfa.TabIndex = 1;
            this.rBtn_Trigger_mangfa.TabStop = true;
            this.rBtn_Trigger_mangfa.Text = "盲发";
            this.rBtn_Trigger_mangfa.UseVisualStyleBackColor = true;
            this.rBtn_Trigger_mangfa.CheckedChanged += new System.EventHandler(this.rBtn_Trigger_mangfa_CheckedChanged);
            // 
            // rBtn_Trigger_woshou
            // 
            this.rBtn_Trigger_woshou.AutoSize = true;
            this.rBtn_Trigger_woshou.Location = new System.Drawing.Point(4, 18);
            this.rBtn_Trigger_woshou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Trigger_woshou.Name = "rBtn_Trigger_woshou";
            this.rBtn_Trigger_woshou.Size = new System.Drawing.Size(47, 16);
            this.rBtn_Trigger_woshou.TabIndex = 0;
            this.rBtn_Trigger_woshou.TabStop = true;
            this.rBtn_Trigger_woshou.Text = "握手";
            this.rBtn_Trigger_woshou.UseVisualStyleBackColor = true;
            // 
            // groupBox_protocol
            // 
            this.groupBox_protocol.Controls.Add(this.rbtn_protocol_buaa);
            this.groupBox_protocol.Controls.Add(this.rBtn_protocol_180908);
            this.groupBox_protocol.Controls.Add(this.rBtn_protocol_rainbow);
            this.groupBox_protocol.Controls.Add(this.rBtn_protocol_reserve);
            this.groupBox_protocol.Location = new System.Drawing.Point(40, 108);
            this.groupBox_protocol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_protocol.Name = "groupBox_protocol";
            this.groupBox_protocol.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_protocol.Size = new System.Drawing.Size(142, 110);
            this.groupBox_protocol.TabIndex = 8;
            this.groupBox_protocol.TabStop = false;
            this.groupBox_protocol.Text = "协议";
            // 
            // rbtn_protocol_buaa
            // 
            this.rbtn_protocol_buaa.AutoSize = true;
            this.rbtn_protocol_buaa.Location = new System.Drawing.Point(8, 17);
            this.rbtn_protocol_buaa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_protocol_buaa.Name = "rbtn_protocol_buaa";
            this.rbtn_protocol_buaa.Size = new System.Drawing.Size(71, 16);
            this.rbtn_protocol_buaa.TabIndex = 0;
            this.rbtn_protocol_buaa.TabStop = true;
            this.rbtn_protocol_buaa.Text = "北航协议";
            this.rbtn_protocol_buaa.UseVisualStyleBackColor = true;
            // 
            // rBtn_protocol_180908
            // 
            this.rBtn_protocol_180908.AutoSize = true;
            this.rBtn_protocol_180908.Location = new System.Drawing.Point(8, 63);
            this.rBtn_protocol_180908.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_protocol_180908.Name = "rBtn_protocol_180908";
            this.rBtn_protocol_180908.Size = new System.Drawing.Size(107, 16);
            this.rBtn_protocol_180908.TabIndex = 0;
            this.rBtn_protocol_180908.TabStop = true;
            this.rBtn_protocol_180908.Text = "180908用户协议";
            this.rBtn_protocol_180908.UseVisualStyleBackColor = true;
            // 
            // rBtn_protocol_rainbow
            // 
            this.rBtn_protocol_rainbow.AutoSize = true;
            this.rBtn_protocol_rainbow.Location = new System.Drawing.Point(8, 40);
            this.rBtn_protocol_rainbow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_protocol_rainbow.Name = "rBtn_protocol_rainbow";
            this.rBtn_protocol_rainbow.Size = new System.Drawing.Size(71, 16);
            this.rBtn_protocol_rainbow.TabIndex = 0;
            this.rBtn_protocol_rainbow.TabStop = true;
            this.rBtn_protocol_rainbow.Text = "润博协议";
            this.rBtn_protocol_rainbow.UseVisualStyleBackColor = true;
            // 
            // rBtn_protocol_reserve
            // 
            this.rBtn_protocol_reserve.AutoSize = true;
            this.rBtn_protocol_reserve.Location = new System.Drawing.Point(8, 86);
            this.rBtn_protocol_reserve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_protocol_reserve.Name = "rBtn_protocol_reserve";
            this.rBtn_protocol_reserve.Size = new System.Drawing.Size(47, 16);
            this.rBtn_protocol_reserve.TabIndex = 0;
            this.rBtn_protocol_reserve.TabStop = true;
            this.rBtn_protocol_reserve.Text = "预留";
            this.rBtn_protocol_reserve.UseVisualStyleBackColor = true;
            // 
            // groupBox_Baud
            // 
            this.groupBox_Baud.Controls.Add(this.rBtn_Baud_614);
            this.groupBox_Baud.Controls.Add(this.rBtn_Baud_115);
            this.groupBox_Baud.Controls.Add(this.rBtn_Baud_460);
            this.groupBox_Baud.Location = new System.Drawing.Point(216, 17);
            this.groupBox_Baud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Baud.Name = "groupBox_Baud";
            this.groupBox_Baud.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Baud.Size = new System.Drawing.Size(91, 87);
            this.groupBox_Baud.TabIndex = 8;
            this.groupBox_Baud.TabStop = false;
            this.groupBox_Baud.Text = "波特率";
            // 
            // rBtn_Baud_115
            // 
            this.rBtn_Baud_115.AutoSize = true;
            this.rBtn_Baud_115.Location = new System.Drawing.Point(4, 42);
            this.rBtn_Baud_115.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Baud_115.Name = "rBtn_Baud_115";
            this.rBtn_Baud_115.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Baud_115.TabIndex = 1;
            this.rBtn_Baud_115.TabStop = true;
            this.rBtn_Baud_115.Text = "115200";
            this.rBtn_Baud_115.UseVisualStyleBackColor = true;
            // 
            // rBtn_Baud_460
            // 
            this.rBtn_Baud_460.AutoSize = true;
            this.rBtn_Baud_460.Location = new System.Drawing.Point(4, 18);
            this.rBtn_Baud_460.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Baud_460.Name = "rBtn_Baud_460";
            this.rBtn_Baud_460.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Baud_460.TabIndex = 0;
            this.rBtn_Baud_460.TabStop = true;
            this.rBtn_Baud_460.Text = "460800";
            this.rBtn_Baud_460.UseVisualStyleBackColor = true;
            // 
            // groupBox_Upd
            // 
            this.groupBox_Upd.Controls.Add(this.rBtn_Upd_2000);
            this.groupBox_Upd.Controls.Add(this.rBtn_Upd_1000);
            this.groupBox_Upd.Controls.Add(this.rBtn_Upd_400);
            this.groupBox_Upd.Controls.Add(this.rBtn_Upd_woshou);
            this.groupBox_Upd.Location = new System.Drawing.Point(220, 108);
            this.groupBox_Upd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Upd.Name = "groupBox_Upd";
            this.groupBox_Upd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Upd.Size = new System.Drawing.Size(114, 110);
            this.groupBox_Upd.TabIndex = 8;
            this.groupBox_Upd.TabStop = false;
            this.groupBox_Upd.Text = "更新率";
            // 
            // rBtn_Upd_1000
            // 
            this.rBtn_Upd_1000.AutoSize = true;
            this.rBtn_Upd_1000.Location = new System.Drawing.Point(4, 62);
            this.rBtn_Upd_1000.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Upd_1000.Name = "rBtn_Upd_1000";
            this.rBtn_Upd_1000.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Upd_1000.TabIndex = 2;
            this.rBtn_Upd_1000.TabStop = true;
            this.rBtn_Upd_1000.Text = "1000Hz";
            this.rBtn_Upd_1000.UseVisualStyleBackColor = true;
            this.rBtn_Upd_1000.CheckedChanged += new System.EventHandler(this.rBtn_Upd_1000_CheckedChanged);
            // 
            // rBtn_Upd_400
            // 
            this.rBtn_Upd_400.AutoSize = true;
            this.rBtn_Upd_400.Location = new System.Drawing.Point(4, 40);
            this.rBtn_Upd_400.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Upd_400.Name = "rBtn_Upd_400";
            this.rBtn_Upd_400.Size = new System.Drawing.Size(53, 16);
            this.rBtn_Upd_400.TabIndex = 1;
            this.rBtn_Upd_400.TabStop = true;
            this.rBtn_Upd_400.Text = "400Hz";
            this.rBtn_Upd_400.UseVisualStyleBackColor = true;
            this.rBtn_Upd_400.CheckedChanged += new System.EventHandler(this.rBtn_Upd_400_CheckedChanged);
            // 
            // rBtn_Upd_woshou
            // 
            this.rBtn_Upd_woshou.AutoSize = true;
            this.rBtn_Upd_woshou.Location = new System.Drawing.Point(4, 18);
            this.rBtn_Upd_woshou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Upd_woshou.Name = "rBtn_Upd_woshou";
            this.rBtn_Upd_woshou.Size = new System.Drawing.Size(47, 16);
            this.rBtn_Upd_woshou.TabIndex = 0;
            this.rBtn_Upd_woshou.TabStop = true;
            this.rBtn_Upd_woshou.Text = "握手";
            this.rBtn_Upd_woshou.UseVisualStyleBackColor = true;
            this.rBtn_Upd_woshou.CheckedChanged += new System.EventHandler(this.rBtn_Upd_woshou_CheckedChanged);
            // 
            // rBtn_Upd_2000
            // 
            this.rBtn_Upd_2000.AutoSize = true;
            this.rBtn_Upd_2000.Location = new System.Drawing.Point(4, 84);
            this.rBtn_Upd_2000.Name = "rBtn_Upd_2000";
            this.rBtn_Upd_2000.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Upd_2000.TabIndex = 3;
            this.rBtn_Upd_2000.TabStop = true;
            this.rBtn_Upd_2000.Text = "2000Hz";
            this.rBtn_Upd_2000.UseVisualStyleBackColor = true;
            // 
            // rBtn_Baud_614
            // 
            this.rBtn_Baud_614.AutoSize = true;
            this.rBtn_Baud_614.Location = new System.Drawing.Point(4, 66);
            this.rBtn_Baud_614.Name = "rBtn_Baud_614";
            this.rBtn_Baud_614.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Baud_614.TabIndex = 2;
            this.rBtn_Baud_614.TabStop = true;
            this.rBtn_Baud_614.Text = "614400";
            this.rBtn_Baud_614.UseVisualStyleBackColor = true;
            // 
            // FrmConfigUart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.groupBox_Upd);
            this.Controls.Add(this.groupBox_Baud);
            this.Controls.Add(this.groupBox_protocol);
            this.Controls.Add(this.groupBox_Trigger);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConfigUart";
            this.Text = "FrmConfigUart";
            this.groupBox_Trigger.ResumeLayout(false);
            this.groupBox_Trigger.PerformLayout();
            this.groupBox_protocol.ResumeLayout(false);
            this.groupBox_protocol.PerformLayout();
            this.groupBox_Baud.ResumeLayout(false);
            this.groupBox_Baud.PerformLayout();
            this.groupBox_Upd.ResumeLayout(false);
            this.groupBox_Upd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Trigger;
        private System.Windows.Forms.RadioButton rBtn_Trigger_mangfa;
        private System.Windows.Forms.RadioButton rBtn_Trigger_woshou;
        private System.Windows.Forms.GroupBox groupBox_protocol;
        private System.Windows.Forms.RadioButton rBtn_protocol_reserve;
        private System.Windows.Forms.RadioButton rbtn_protocol_buaa;
        private System.Windows.Forms.RadioButton rBtn_protocol_180908;
        private System.Windows.Forms.RadioButton rBtn_protocol_rainbow;
        private System.Windows.Forms.GroupBox groupBox_Baud;
        private System.Windows.Forms.RadioButton rBtn_Baud_115;
        private System.Windows.Forms.RadioButton rBtn_Baud_460;
        private System.Windows.Forms.GroupBox groupBox_Upd;
        private System.Windows.Forms.RadioButton rBtn_Upd_400;
        private System.Windows.Forms.RadioButton rBtn_Upd_woshou;
        private System.Windows.Forms.RadioButton rBtn_Upd_1000;
        private System.Windows.Forms.RadioButton rBtn_Baud_614;
        private System.Windows.Forms.RadioButton rBtn_Upd_2000;
    }
}