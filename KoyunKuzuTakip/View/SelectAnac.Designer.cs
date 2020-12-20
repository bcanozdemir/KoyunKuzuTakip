namespace KoyunKuzuTakip
{
    partial class SelectAnac
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
            this.anacList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anacList
            // 
            this.anacList.FormattingEnabled = true;
            this.anacList.Location = new System.Drawing.Point(12, 39);
            this.anacList.Name = "anacList";
            this.anacList.Size = new System.Drawing.Size(121, 21);
            this.anacList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anaç Küpe No";
            // 
            // secButton
            // 
            this.secButton.Location = new System.Drawing.Point(12, 75);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(121, 23);
            this.secButton.TabIndex = 3;
            this.secButton.Text = "Seç";
            this.secButton.UseVisualStyleBackColor = true;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Yeni Anaç Oluştur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectAnac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 147);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.secButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anacList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectAnac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anaç Seç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox anacList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.Button button3;
    }
}