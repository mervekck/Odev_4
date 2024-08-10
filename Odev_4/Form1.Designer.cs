namespace Odev_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbLog = new ComboBox();
            lblSonuc = new Label();
            btnKaydet = new Button();
            txtDurum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 60);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Log Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 130);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Durum";
            // 
            // cmbLog
            // 
            cmbLog.FormattingEnabled = true;
            cmbLog.Items.AddRange(new object[] { "Seçiniz", "DbLog", "XmlLog", "JsonLog" });
            cmbLog.Location = new Point(228, 57);
            cmbLog.Name = "cmbLog";
            cmbLog.Size = new Size(300, 28);
            cmbLog.TabIndex = 1;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(110, 307);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuç:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(429, 200);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(99, 58);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(228, 127);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(300, 27);
            txtDurum.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(txtDurum);
            Controls.Add(btnKaydet);
            Controls.Add(lblSonuc);
            Controls.Add(cmbLog);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLog;
        private Label lblSonuc;
        private Button btnKaydet;
        private TextBox txtDurum;
    }
}
