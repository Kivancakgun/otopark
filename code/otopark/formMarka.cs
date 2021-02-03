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
    public partial class formMarka : Form
    {
        public formMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");

        private void buttonMarkaEkle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand markaEkle = new SqlCommand("insert into tblMarkaBilgileri(marka) values('" + textBoxMarkaEkle.Text + "')", baglanti);
                markaEkle.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Dispose();
                MessageBox.Show("Marka Başarıyla Eklendi");
                textBoxMarkaEkle.Clear();
            }
        }
    }
}
