namespace KoyunKuzuTakip
{
    partial class SelectGender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGender));
            this.koyunResim = new System.Windows.Forms.PictureBox();
            this.kocResim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtreAraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.koyunResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocResim)).BeginInit();
            this.SuspendLayout();
            // 
            // koyunResim
            // 
            this.koyunResim.Image = ((System.Drawing.Image)(resources.GetObject("koyunResim.Image")));
            this.koyunResim.Location = new System.Drawing.Point(322, 216);
            this.koyunResim.Name = "koyunResim";
            this.koyunResim.Size = new System.Drawing.Size(150, 150);
            this.koyunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.koyunResim.TabIndex = 0;
            this.koyunResim.TabStop = false;
            this.koyunResim.Click += new System.EventHandler(this.koyunResim_Click);
            // 
            // kocResim
            // 
            this.kocResim.Image = ((System.Drawing.Image)(resources.GetObject("kocResim.Image")));
            this.kocResim.Location = new System.Drawing.Point(650, 216);
            this.kocResim.Name = "kocResim";
            this.kocResim.Size = new System.Drawing.Size(150, 150);
            this.kocResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kocResim.TabIndex = 1;
            this.kocResim.TabStop = false;
            this.kocResim.Click += new System.EventHandler(this.kocResim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(373, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koyun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(711, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koç";
            // 
            // filtreAraBtn
            // 
            this.filtreAraBtn.Location = new System.Drawing.Point(322, 407);
            this.filtreAraBtn.Name = "filtreAraBtn";
            this.filtreAraBtn.Size = new System.Drawing.Size(150, 28);
            this.filtreAraBtn.TabIndex = 4;
            this.filtreAraBtn.Text = "Filtreli Arama";
            this.filtreAraBtn.UseVisualStyleBackColor = true;
            this.filtreAraBtn.Click += new System.EventHandler(this.filtreAraBtn_Click);
            // 
            // SelectGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1149, 569);
            this.Controls.Add(this.filtreAraBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kocResim);
            this.Controls.Add(this.koyunResim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectGender";
            this.Text = "SelectGender";
            ((System.ComponentModel.ISupportInitialize)(this.koyunResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox koyunResim;
        private System.Windows.Forms.PictureBox kocResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filtreAraBtn;
    }
}