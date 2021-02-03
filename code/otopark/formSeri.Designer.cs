
namespace otopark
{
    partial class formSeri
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
            this.buttonSeriEkle = new System.Windows.Forms.Button();
            this.labelSeriMarka = new System.Windows.Forms.Label();
            this.textBoxSeriAdi = new System.Windows.Forms.TextBox();
            this.comboBoxMarkaAdi = new System.Windows.Forms.ComboBox();
            this.labelSeri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeriEkle
            // 
            this.buttonSeriEkle.Location = new System.Drawing.Point(140, 145);
            this.buttonSeriEkle.Name = "buttonSeriEkle";
            this.buttonSeriEkle.Size = new System.Drawing.Size(101, 35);
            this.buttonSeriEkle.TabIndex = 5;
            this.buttonSeriEkle.Text = "Ekle";
            this.buttonSeriEkle.UseVisualStyleBackColor = true;
            this.buttonSeriEkle.Click += new System.EventHandler(this.buttonSeriEkle_Click);
            // 
            // labelSeriMarka
            // 
            this.labelSeriMarka.AutoSize = true;
            this.labelSeriMarka.Location = new System.Drawing.Point(57, 60);
            this.labelSeriMarka.Name = "labelSeriMarka";
            this.labelSeriMarka.Size = new System.Drawing.Size(47, 17);
            this.labelSeriMarka.TabIndex = 4;
            this.labelSeriMarka.Text = "Marka";
            // 
            // textBoxSeriAdi
            // 
            this.textBoxSeriAdi.Location = new System.Drawing.Point(125, 101);
            this.textBoxSeriAdi.Name = "textBoxSeriAdi";
            this.textBoxSeriAdi.Size = new System.Drawing.Size(136, 22);
            this.textBoxSeriAdi.TabIndex = 3;
            // 
            // comboBoxMarkaAdi
            // 
            this.comboBoxMarkaAdi.FormattingEnabled = true;
            this.comboBoxMarkaAdi.Location = new System.Drawing.Point(125, 57);
            this.comboBoxMarkaAdi.Name = "comboBoxMarkaAdi";
            this.comboBoxMarkaAdi.Size = new System.Drawing.Size(136, 24);
            this.comboBoxMarkaAdi.TabIndex = 6;
            // 
            // labelSeri
            // 
            this.labelSeri.AutoSize = true;
            this.labelSeri.Location = new System.Drawing.Point(64, 101);
            this.labelSeri.Name = "labelSeri";
            this.labelSeri.Size = new System.Drawing.Size(33, 17);
            this.labelSeri.TabIndex = 7;
            this.labelSeri.Text = "Seri";
            // 
            // formSeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 245);
            this.Controls.Add(this.labelSeri);
            this.Controls.Add(this.comboBoxMarkaAdi);
            this.Controls.Add(this.buttonSeriEkle);
            this.Controls.Add(this.labelSeriMarka);
            this.Controls.Add(this.textBoxSeriAdi);
            this.Name = "formSeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seri Ekle";
            this.Load += new System.EventHandler(this.formSeri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeriEkle;
        private System.Windows.Forms.Label labelSeriMarka;
        private System.Windows.Forms.TextBox textBoxSeriAdi;
        private System.Windows.Forms.ComboBox comboBoxMarkaAdi;
        private System.Windows.Forms.Label labelSeri;
    }
}