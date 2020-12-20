namespace KoyunKuzuTakip.View
{
    partial class NewAnac
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.secButton = new System.Windows.Forms.Button();
            this.anacKupeNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anaç Küpe No";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // secButton
            // 
            this.secButton.Location = new System.Drawing.Point(12, 118);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(173, 23);
            this.secButton.TabIndex = 5;
            this.secButton.Text = "Oluştur";
            this.secButton.UseVisualStyleBackColor = true;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // anacKupeNo
            // 
            this.anacKupeNo.Location = new System.Drawing.Point(12, 38);
            this.anacKupeNo.Name = "anacKupeNo";
            this.anacKupeNo.Size = new System.Drawing.Size(121, 20);
            this.anacKupeNo.TabIndex = 7;
            // 
            // NewAnac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 180);
            this.Controls.Add(this.anacKupeNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.secButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewAnac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAnac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.TextBox anacKupeNo;
    }
}