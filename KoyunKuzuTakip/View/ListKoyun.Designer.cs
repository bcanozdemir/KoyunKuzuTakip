namespace KoyunKuzuTakip.View
{
    partial class ListKoyun
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
            this.koyunDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.KupeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoyunIsletmeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahminiDogurmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumAgirligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasiyorMu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satildiMi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.koyunDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // koyunDGV
            // 
            this.koyunDGV.AllowUserToAddRows = false;
            this.koyunDGV.AllowUserToDeleteRows = false;
            this.koyunDGV.AllowUserToResizeRows = false;
            this.koyunDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.koyunDGV.BackgroundColor = System.Drawing.Color.White;
            this.koyunDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.koyunDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.koyunDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.koyunDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KupeNo,
            this.KoyunIsletmeNo,
            this.Cinsiyet,
            this.TahminiDogurmaTarihi,
            this.DogumAgirligi,
            this.yasiyorMu,
            this.satildiMi});
            this.koyunDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koyunDGV.GridColor = System.Drawing.SystemColors.Control;
            this.koyunDGV.Location = new System.Drawing.Point(3, 3);
            this.koyunDGV.Name = "koyunDGV";
            this.koyunDGV.ReadOnly = true;
            this.koyunDGV.RowHeadersVisible = false;
            this.koyunDGV.RowHeadersWidth = 25;
            this.koyunDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.koyunDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.koyunDGV.Size = new System.Drawing.Size(1143, 528);
            this.koyunDGV.TabIndex = 0;
            this.koyunDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.koyunDGV_CellClick);
            this.koyunDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.koyunDGV_CellContentClick);
            this.koyunDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.koyunDGV_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.koyunDGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.0246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.975395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 569);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yeniEkleBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 29);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1020, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KupeNo
            // 
            this.KupeNo.HeaderText = "Küpe No";
            this.KupeNo.Name = "KupeNo";
            this.KupeNo.ReadOnly = true;
            // 
            // KoyunIsletmeNo
            // 
            this.KoyunIsletmeNo.HeaderText = "Koyun İşletme No";
            this.KoyunIsletmeNo.Name = "KoyunIsletmeNo";
            this.KoyunIsletmeNo.ReadOnly = true;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            // 
            // TahminiDogurmaTarihi
            // 
            this.TahminiDogurmaTarihi.HeaderText = "Tahmini Doğurma Tarihi";
            this.TahminiDogurmaTarihi.Name = "TahminiDogurmaTarihi";
            this.TahminiDogurmaTarihi.ReadOnly = true;
            // 
            // DogumAgirligi
            // 
            this.DogumAgirligi.HeaderText = "Doğum Ağırlığı";
            this.DogumAgirligi.Name = "DogumAgirligi";
            this.DogumAgirligi.ReadOnly = true;
            // 
            // yasiyorMu
            // 
            this.yasiyorMu.HeaderText = "Yaşıyor Mu";
            this.yasiyorMu.Name = "yasiyorMu";
            this.yasiyorMu.ReadOnly = true;
            // 
            // satildiMi
            // 
            this.satildiMi.HeaderText = "Satıldı Mı";
            this.satildiMi.Name = "satildiMi";
            this.satildiMi.ReadOnly = true;
            // 
            // yeniEkleBtn
            // 
            this.yeniEkleBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.yeniEkleBtn.Location = new System.Drawing.Point(897, 0);
            this.yeniEkleBtn.Name = "yeniEkleBtn";
            this.yeniEkleBtn.Size = new System.Drawing.Size(123, 29);
            this.yeniEkleBtn.TabIndex = 1;
            this.yeniEkleBtn.Text = "Yeni Koyun Ekle";
            this.yeniEkleBtn.UseVisualStyleBackColor = true;
            this.yeniEkleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListKoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListKoyun";
            this.Text = "ListKoyun";
            ((System.ComponentModel.ISupportInitialize)(this.koyunDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView koyunDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoyunIsletmeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahminiDogurmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumAgirligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasiyorMu;
        private System.Windows.Forms.DataGridViewTextBoxColumn satildiMi;
        private System.Windows.Forms.Button yeniEkleBtn;
    }
}