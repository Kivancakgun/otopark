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
    public partial class formSatis : Form
    {
        public formSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KıVANÇ\\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=True");

        DataSet dset = new DataSet();

        private void formSatis_Load(object sender, EventArgs e)
        {
            SatislariListele();
            Hesapla();

        }

        private void Hesapla()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(tutar) from tblSatis", baglanti);
                labelSatisMessage.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            
        }

        private void SatislariListele()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlDataAdapter adptr = new SqlDataAdapter("select * from tblSatis", baglanti);
                adptr.Fill(dset, "satis");
                dataGridViewSatis.DataSource = dset.Tables["satis"];
                baglanti.Close();
            }
        }
    }
}
