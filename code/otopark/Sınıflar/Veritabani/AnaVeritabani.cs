using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace otopark.Sınıflar.Veritabani
{
    abstract class AnaVeritabani
    {
            string yol = @"Data Source=KıVANÇ\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=SSPI";
            public SqlDataAdapter adaptor;
            public DataTable tablo;
            public SqlCommand komut;
            public SqlConnection baglanti;
            public object ConfigurationManager { get; private set; }
            public AnaVeritabani()
            {
                yol = @"Data Source=KıVANÇ\SQLEXPRESS;Initial Catalog=KA_Otopark;Integrated Security=SSPI";
            }

            public void Baglan()
            {
                // Veritabanı bağlantısı
                baglanti = new SqlConnection(yol);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
            }
            abstract public void Giris(object obj);
            abstract public void Ucret(object obj);
            abstract public void Cikis(object obj);
            abstract public DataTable Listele(object obj);
            abstract public DataTable Listele();
        }
    }

