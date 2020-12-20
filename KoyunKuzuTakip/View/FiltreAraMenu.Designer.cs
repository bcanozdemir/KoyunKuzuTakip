namespace KoyunKuzuTakip.View
{
    partial class FiltreAraMenu
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
            this.koyunSatildiMiCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.koyunYasiyorMuCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.koyunCinsiyetCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.devletAsi = new System.Windows.Forms.TextBox();
            this.isletmeAsi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // koyunSatildiMiCb
            // 
            this.koyunSatildiMiCb.FormattingEnabled = true;
            this.koyunSatildiMiCb.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.koyunSatildiMiCb.Location = new System.Drawing.Point(9, 146);
            this.koyunSatildiMiCb.Name = "koyunSatildiMiCb";
            this.koyunSatildiMiCb.Size = new System.Drawing.Size(100, 21);
            this.koyunSatildiMiCb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Koyun Satıldı Mı";
            // 
            // koyunYasiyorMuCb
            // 
            this.koyunYasiyorMuCb.FormattingEnabled = true;
            this.koyunYasiyorMuCb.Items.AddRange(new object[] {
            "ÖLÜ",
            "CANLI"});
            this.koyunYasiyorMuCb.Location = new System.Drawing.Point(9, 94);
            this.koyunYasiyorMuCb.Name = "koyunYasiyorMuCb";
            this.koyunYasiyorMuCb.Size = new System.Drawing.Size(100, 21);
            this.koyunYasiyorMuCb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Koyun Yaşıyor Mu";
            // 
            // koyunCinsiyetCb
            // 
            this.koyunCinsiyetCb.FormattingEnabled = true;
            this.koyunCinsiyetCb.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK"});
            this.koyunCinsiyetCb.Location = new System.Drawing.Point(9, 37);
            this.koyunCinsiyetCb.Name = "koyunCinsiyetCb";
            this.koyunCinsiyetCb.Size = new System.Drawing.Size(100, 21);
            this.koyunCinsiyetCb.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Koyun Cinsiyet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Devlet Aşıları";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "İşleme Aşıları";
            // 
            // devletAsi
            // 
            this.devletAsi.Location = new System.Drawing.Point(9, 198);
            this.devletAsi.Name = "devletAsi";
            this.devletAsi.Size = new System.Drawing.Size(100, 20);
            this.devletAsi.TabIndex = 38;
            // 
            // isletmeAsi
            // 
            this.isletmeAsi.Location = new System.Drawing.Point(190, 147);
            this.isletmeAsi.Name = "isletmeAsi";
            this.isletmeAsi.Size = new System.Drawing.Size(100, 20);
            this.isletmeAsi.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(9, 324);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(100, 23);
            this.iptalBtn.TabIndex = 41;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK"});
            this.comboBox1.Location = new System.Drawing.Point(190, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "İşletme No";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK"});
            this.comboBox2.Location = new System.Drawing.Point(190, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Doğum Tarihi";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK"});
            this.comboBox3.Location = new System.Drawing.Point(190, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Küpe No";
            // 
            // FiltreAraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 352);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isletmeAsi);
            this.Controls.Add(this.devletAsi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.koyunSatildiMiCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.koyunYasiyorMuCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.koyunCinsiyetCb);
            this.Controls.Add(this.label4);
            this.Name = "FiltreAraMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltreAraMenu";
            this.Load += new System.EventHandler(this.FiltreAraMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox koyunSatildiMiCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox koyunYasiyorMuCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox koyunCinsiyetCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox devletAsi;
        private System.Windows.Forms.TextBox isletmeAsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
    }
}