using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otopark
{
    public partial class formAracGiris : Form
    {
        public formAracGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");
 
        private void formAracGiris_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Marka();
        }

        private void Marka()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select marka from tblMarkaBilgileri", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxMarka.Items.Add(read["marka"].ToString());

                }
                baglanti.Close();
            }
            
        }

        private void BosAraclar()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracDurum where durumu='BOŞ'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxParkYeri.Items.Add(read["parkYeri"].ToString());

                }
                baglanti.Close();
            }
            
        }

        private void buttonAracKayitIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAracKayit_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into tblAracOtoparkKaydi(tc,adi,soyadi,telefon,email,plaka,marka,seri,renk,parkYeri,tarih) values(@tc,@adi,@soyadi,@telefon,@email,@plaka,@marka,@seri,@renk,@parkYeri,@tarih)", baglanti);
                ekle.Parameters.AddWithValue("@tc", textBoxTc.Text);
                ekle.Parameters.AddWithValue("@adi", textBoxAdi.Text);
                ekle.Parameters.AddWithValue("@soyadi", textBoxSoyadi.Text);
                ekle.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
                ekle.Parameters.AddWithValue("@email", textBoxEmail.Text);
                ekle.Parameters.AddWithValue("@plaka", textBoxPlaka.Text);
                ekle.Parameters.AddWithValue("@marka", comboBoxMarka.Text);
                ekle.Parameters.AddWithValue("@seri", comboBoxSeri.Text);
                ekle.Parameters.AddWithValue("@renk", textBoxRenk.Text);
                ekle.Parameters.AddWithValue("@parkYeri", comboBoxParkYeri.Text);
                ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                ekle.ExecuteNonQuery();

                SqlCommand guncelle = new SqlCommand("update tblAracDurum set durumu='DOLU' where parkYeri='" + comboBoxParkYeri.SelectedItem + "'", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
            
            MessageBox.Show("Araç Kaydı Başarı İle Oluşturuldu.", "Kayıt");
            comboBoxParkYeri.Items.Clear();
            BosAraclar();
            comboBoxMarka.Items.Clear();
            Marka();
            comboBoxSeri.Items.Clear();
            foreach (Control item in groupBoxKisi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBoxArac.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBoxArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void buttonAracMarkaEkle_Click(object sender, EventArgs e)
        {
            formMarka marka = new formMarka();
            marka.ShowDialog();
        }

        private void buttonAracSeriEkle_Click(object sender, EventArgs e)
        {
            formSeri seri = new formSeri();
            seri.ShowDialog();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSeri.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select seri from tblSeriBilgileri where marka='" + comboBoxMarka.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxSeri.Items.Add(read["seri"].ToString());
                }
                baglanti.Close();
            }
            
        }
    }
}
