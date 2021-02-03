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
    public partial class formSeri : Form
    {
        public formSeri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");

        private void marka()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select marka from tblMarkaBilgileri", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxMarkaAdi.Items.Add(read["marka"].ToString());

                }
                baglanti.Close();
            }
            
        }
        private void formSeri_Load(object sender, EventArgs e)
        {
            marka();
        }

        private void buttonSeriEkle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand seriEkle = new SqlCommand("insert into tblSeriBilgileri(marka,seri) values('" + comboBoxMarkaAdi.Text + "','" + textBoxSeriAdi.Text + "')", baglanti);
                seriEkle.ExecuteNonQuery();
                baglanti.Close();
            }
            
            MessageBox.Show("Markaya Bağlı Araç Serisi Başarıyla Eklendi");
            textBoxSeriAdi.Clear();
            comboBoxMarkaAdi.Text = "";
            comboBoxMarkaAdi.Items.Clear();
            marka();
        }
    }
}
