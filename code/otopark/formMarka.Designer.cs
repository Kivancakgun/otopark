
namespace otopark
{
    partial class formMarka
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
            this.textBoxMarkaEkle = new System.Windows.Forms.TextBox();
            this.labelMarkaEkle = new System.Windows.Forms.Label();
            this.buttonMarkaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMarkaEkle
            // 
            this.textBoxMarkaEkle.Location = new System.Drawing.Point(106, 87);
            this.textBoxMarkaEkle.Name = "textBoxMarkaEkle";
            this.textBoxMarkaEkle.Size = new System.Drawing.Size(136, 22);
            this.textBoxMarkaEkle.TabIndex = 0;
            // 
            // labelMarkaEkle
            // 
            this.labelMarkaEkle.AutoSize = true;
            this.labelMarkaEkle.Location = new System.Drawing.Point(44, 90);
            this.labelMarkaEkle.Name = "labelMarkaEkle";
            this.labelMarkaEkle.Size = new System.Drawing.Size(47, 17);
            this.labelMarkaEkle.TabIndex = 1;
            this.labelMarkaEkle.Text = "Marka";
            // 
            // buttonMarkaEkle
            // 
            this.buttonMarkaEkle.Location = new System.Drawing.Point(121, 136);
            this.buttonMarkaEkle.Name = "buttonMarkaEkle";
            this.buttonMarkaEkle.Size = new System.Drawing.Size(101, 35);
            this.buttonMarkaEkle.TabIndex = 2;
            this.buttonMarkaEkle.Text = "Ekle";
            this.buttonMarkaEkle.UseVisualStyleBackColor = true;
            this.buttonMarkaEkle.Click += new System.EventHandler(this.buttonMarkaEkle_Click);
            // 
            // formMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 258);
            this.Controls.Add(this.buttonMarkaEkle);
            this.Controls.Add(this.labelMarkaEkle);
            this.Controls.Add(this.textBoxMarkaEkle);
            this.Name = "formMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarkaEkle;
        private System.Windows.Forms.Label labelMarkaEkle;
        private System.Windows.Forms.Button buttonMarkaEkle;
    }
}