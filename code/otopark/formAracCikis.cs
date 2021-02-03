using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class formAracCikis : Form
    {
        public formAracCikis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");
        private void formAracCikis_Load(object sender, EventArgs e)
        {
            DoluYerler();
            Plakalar();
            timer1.Enabled = true;
        }
        private void Plakalar()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracOtoparkKaydi", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxPlaka.Items.Add(read["plaka"].ToString());
                }
                baglanti.Close();
            }
        }

        private void DoluYerler()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracDurum where durumu='DOLU'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxParkYeri.Items.Add(read["parkYeri"].ToString());
                }
                baglanti.Close();
            }
        }

        private void comboBoxPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracOtoparkKaydi where plaka='" + comboBoxPlaka.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textBoxParkYeri.Text = read["parkYeri"].ToString();
                }
                baglanti.Close();
            }
        }
        private void comboBoxParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracOtoparkKaydi where parkYeri= '" + comboBoxParkYeri.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textBoxParkYeriKontrol.Text = read["parkYeri"].ToString();
                    textBoxTC.Text = read["tc"].ToString();
                    textBoxAd.Text = read["adi"].ToString();
                    textBoxSoyad.Text = read["soyadi"].ToString();
                    textBoxMarka.Text = read["marka"].ToString();
                    textBoxSeri.Text = read["seri"].ToString();
                    textBoxPlaka.Text = read["plaka"].ToString();
                    labelGelisTarihi.Text = read["tarih"].ToString();
                }

                baglanti.Close();
            }

            labelSure.Visible = true;
            labelToplamTutar.Visible = true;
            labelGelisTarihi.Visible = true;
            label15.Visible = true;
            DateTime gelis, cikis;
            gelis = DateTime.Parse(labelGelisTarihi.Text);
            cikis = DateTime.Parse(labelCikisTarihi.Text);
            TimeSpan fark;
            fark = cikis-gelis;
            labelSure.Text = fark.TotalHours.ToString("0.00");
            if (fark.TotalHours <= 2)
            {
                labelToplamTutar.Text = (double.Parse(labelSure.Text) * (8)).ToString("0.00");
            }
            else if (fark.TotalHours <= 4)
            {
                labelToplamTutar.Text = (double.Parse(labelSure.Text) * (7)).ToString("0.00");
            }
            else if (fark.TotalHours <= 8)
            {
                labelToplamTutar.Text = (double.Parse(labelSure.Text) * (6)).ToString("0.00");
            }
            else if (fark.TotalHours <= 24)
            {
                labelToplamTutar.Text = (double.Parse(labelSure.Text) * (5)).ToString("0.00");
            }
            else
            {
                labelToplamTutar.Text = (double.Parse(labelSure.Text) * (4)).ToString("0.00");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void buttonAracCikisi_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand plaka = new SqlCommand("delete from tblAracOtoparkKaydi where plaka= '" + textBoxPlaka.Text + "' ", baglanti);
                plaka.ExecuteNonQuery();

                SqlCommand durumu = new SqlCommand("update tblAracDurum set durumu='BOŞ' where parkYeri= '" + textBoxParkYeriKontrol.Text + "' ", baglanti);
                durumu.ExecuteNonQuery();

                SqlCommand satis = new SqlCommand("insert into tblSatis(parkyeri,plaka,gelisTarihi,cikisTarihi,süre,tutar) values(@parkyeri,@plaka,@gelisTarihi,@cikisTarihi,@süre,@tutar)", baglanti);
                satis.Parameters.AddWithValue("@parkyeri", textBoxParkYeriKontrol.Text);
                satis.Parameters.AddWithValue("@plaka", textBoxPlaka.Text);
                satis.Parameters.AddWithValue("@gelisTarihi", labelGelisTarihi.Text);
                satis.Parameters.AddWithValue("@cikisTarihi", labelCikisTarihi.Text);
                satis.Parameters.AddWithValue("@süre", double.Parse(labelSure.Text));
                satis.Parameters.AddWithValue("@tutar", double.Parse(labelToplamTutar.Text));
                satis.ExecuteNonQuery();
                baglanti.Close();
            }
            
            MessageBox.Show("Araç Çıkışı Başarıyla Yapıldı.");
            foreach (Control item in groupBoxAracBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    textBoxParkYeri.Text = "";
                    comboBoxParkYeri.Text = "";
                    comboBoxPlaka.Text = "";
                }
            }
            comboBoxPlaka.Items.Clear();
            comboBoxParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }
        private void buttonAracCikisiIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
