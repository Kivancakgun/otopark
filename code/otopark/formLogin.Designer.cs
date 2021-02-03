
namespace otopark
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginKAdi = new System.Windows.Forms.Label();
            this.LoginParola = new System.Windows.Forms.Label();
            this.label_LoginMessage = new System.Windows.Forms.Label();
            this.textBox_LoginKAdi = new System.Windows.Forms.TextBox();
            this.button_LoginGiris = new System.Windows.Forms.Button();
            this.textBox_LoginParola = new System.Windows.Forms.TextBox();
            this.buttonLoginCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginKAdi
            // 
            this.LoginKAdi.AutoSize = true;
            this.LoginKAdi.Location = new System.Drawing.Point(78, 58);
            this.LoginKAdi.Name = "LoginKAdi";
            this.LoginKAdi.Size = new System.Drawing.Size(41, 17);
            this.LoginKAdi.TabIndex = 0;
            this.LoginKAdi.Text = "K.Adı";
            // 
            // LoginParola
            // 
            this.LoginParola.AutoSize = true;
            this.LoginParola.Location = new System.Drawing.Point(78, 104);
            this.LoginParola.Name = "LoginParola";
            this.LoginParola.Size = new System.Drawing.Size(49, 17);
            this.LoginParola.TabIndex = 0;
            this.LoginParola.Text = "Parola";
            // 
            // label_LoginMessage
            // 
            this.label_LoginMessage.AutoSize = true;
            this.label_LoginMessage.Location = new System.Drawing.Point(284, 226);
            this.label_LoginMessage.Name = "label_LoginMessage";
            this.label_LoginMessage.Size = new System.Drawing.Size(100, 17);
            this.label_LoginMessage.TabIndex = 0;
            this.label_LoginMessage.Text = "LoginMessage";
            // 
            // textBox_LoginKAdi
            // 
            this.textBox_LoginKAdi.Location = new System.Drawing.Point(156, 58);
            this.textBox_LoginKAdi.Name = "textBox_LoginKAdi";
            this.textBox_LoginKAdi.Size = new System.Drawing.Size(150, 22);
            this.textBox_LoginKAdi.TabIndex = 1;
            this.textBox_LoginKAdi.Text = "KA";
            // 
            // button_LoginGiris
            // 
            this.button_LoginGiris.Location = new System.Drawing.Point(193, 148);
            this.button_LoginGiris.Name = "button_LoginGiris";
            this.button_LoginGiris.Size = new System.Drawing.Size(75, 30);
            this.button_LoginGiris.TabIndex = 4;
            this.button_LoginGiris.Text = "Giriş";
            this.button_LoginGiris.UseVisualStyleBackColor = true;
            this.button_LoginGiris.Click += new System.EventHandler(this.button_LoginGiris_Click);
            // 
            // textBox_LoginParola
            // 
            this.textBox_LoginParola.Location = new System.Drawing.Point(156, 104);
            this.textBox_LoginParola.Name = "textBox_LoginParola";
            this.textBox_LoginParola.Size = new System.Drawing.Size(154, 22);
            this.textBox_LoginParola.TabIndex = 2;
            this.textBox_LoginParola.Text = "123456";
            this.textBox_LoginParola.UseSystemPasswordChar = true;
            // 
            // buttonLoginCikis
            // 
            this.buttonLoginCikis.Location = new System.Drawing.Point(193, 184);
            this.buttonLoginCikis.Name = "buttonLoginCikis";
            this.buttonLoginCikis.Size = new System.Drawing.Size(75, 30);
            this.buttonLoginCikis.TabIndex = 4;
            this.buttonLoginCikis.Text = "Çıkış";
            this.buttonLoginCikis.UseVisualStyleBackColor = true;
            this.buttonLoginCikis.Click += new System.EventHandler(this.button_LoginCikis_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 266);
            this.Controls.Add(this.buttonLoginCikis);
            this.Controls.Add(this.button_LoginGiris);
            this.Controls.Add(this.textBox_LoginParola);
            this.Controls.Add(this.textBox_LoginKAdi);
            this.Controls.Add(this.label_LoginMessage);
            this.Controls.Add(this.LoginParola);
            this.Controls.Add(this.LoginKAdi);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginKAdi;
        private System.Windows.Forms.Label LoginParola;
        private System.Windows.Forms.Label label_LoginMessage;
        private System.Windows.Forms.TextBox textBox_LoginKAdi;
        private System.Windows.Forms.Button button_LoginGiris;
        private System.Windows.Forms.TextBox textBox_LoginParola;
        private System.Windows.Forms.Button buttonLoginCikis;
    }
}

