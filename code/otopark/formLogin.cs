using otopark.Sınıflar.Varliklar;
using otopark.Sınıflar.Veritabani;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            label_LoginMessage.Text = "";
        }
        private void button_LoginGiris_Click(object sender, EventArgs e)
        {
            /*
             * veritabanı bağlanacak
             * sorgu çekicek
             * Eğer kaydımız veritabanında varsa Anasayfa yönledirecek
             * Yoksada hata verecek
             */
            try
            {
                Calisan cls = new Calisan();
                cls.KAdi = textBox_LoginKAdi.Text;
                cls.Parola = textBox_LoginParola.Text;


                CalisanVeritabani clsVt = new CalisanVeritabani();

                DataTable tablo = new DataTable();
                tablo = clsVt.Listele(cls);

                if (tablo.Rows.Count > 0)
                {
                    Login.Adi = tablo.Rows[0]["Adi"].ToString();
                    Login.KAdi = tablo.Rows[0]["KAdi"].ToString();
                    Login.Id = int.Parse(tablo.Rows[0]["Id"].ToString());
                    Login.Soyadi = tablo.Rows[0]["Soyadi"].ToString();
                    Login.Parola = tablo.Rows[0]["Parola"].ToString();

                    

                    formAnaSayfa frm = new formAnaSayfa();
                    frm.Show();
                    this.Hide();
                }

                else
                {
                    label_LoginMessage.Text = "Kullanıcı Bilgileriniz Hatalı!";
                }

            }
            catch (Exception hata)
            {

                label_LoginMessage.Text = "Giriş hata : " + hata.Message.ToString();
            }
        }

        private void button_LoginCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
    
}
