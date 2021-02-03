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
using otopark.Sınıflar.Varliklar;
using otopark.Sınıflar.Veritabani;

namespace otopark
{
    public partial class formOtoparkDurumu : Form
    {
        
        public formOtoparkDurumu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");
        private void formOtoparkDurumu_Load(object sender, EventArgs e)
        {
            BosParkYerleri();
            DoluParkYerleri();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tblAracOtoparkKaydi", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    foreach (Control item in Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Text == read["parkYeri"].ToString())
                            {
                                item.Text = read["plaka"].ToString();
                            }
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            if (baglanti.State == ConnectionState.Closed) { 
                baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblAracDurum", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {

                        if (item.Text == read["parkYeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                        

                    }
                }
            }
                baglanti.Close();
            }
            
        }

        private void BosParkYerleri()
        {
            int sayac = 1;
            int sayacKapasite = 0;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    labelKapasite.Text = "";
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                    sayacKapasite=sayac-1;
                    labelKapasite.Text = "Toplam Kapasite=" + sayacKapasite.ToString();
                }
            }  
            
        }
    }
}
