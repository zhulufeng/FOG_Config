namespace FOG_Config
{
    partial class FrmGyroNoSetDlg
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
            this.comBox_GryoNo = new System.Windows.Forms.ComboBox();
            this.tBox_GyroNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comBox_GryoNo
            // 
            this.comBox_GryoNo.FormattingEnabled = true;
            this.comBox_GryoNo.Items.AddRange(new object[] {
            "F50",
            "F60",
            "F70",
            "F98",
            "F120"});
            this.comBox_GryoNo.Location = new System.Drawing.Point(212, 84);
            this.comBox_GryoNo.Name = "comBox_GryoNo";
            this.comBox_GryoNo.Size = new System.Drawing.Size(121, 32);
            this.comBox_GryoNo.TabIndex = 0;
            // 
            // tBox_GyroNo
            // 
            this.tBox_GyroNo.Location = new System.Drawing.Point(507, 81);
            this.tBox_GyroNo.Name = "tBox_GyroNo";
            this.tBox_GyroNo.Size = new System.Drawing.Size(167, 35);
            this.tBox_GyroNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "陀螺型号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "陀螺编号";
            // 
            // Btn_OK
            // 
            this.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OK.Location = new System.Drawing.Point(139, 155);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(144, 52);
            this.Btn_OK.TabIndex = 4;
            this.Btn_OK.Text = "确认";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(414, 155);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(154, 52);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // FrmGyroNoSetDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_GyroNo);
            this.Controls.Add(this.comBox_GryoNo);
            this.Name = "FrmGyroNoSetDlg";
            this.Text = "GryoNoSetDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox_GryoNo;
        private System.Windows.Forms.TextBox tBox_GyroNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}