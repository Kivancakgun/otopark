using otopark.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace otopark.Sınıflar.Veritabani
{
    class CalisanVeritabani : AnaVeritabani
    {
        public override void Cikis(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Giris(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(object obj)
        {
            Calisan cls = (Calisan)obj;
            Baglan();
            string sorgu = " select * from tblCalisan where ( KAdi = '" + cls.KAdi + "' ) " + " and ( Parola = '" + cls.Parola + "') ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele()
        {
            throw new NotImplementedException();
        }

        public override void Ucret(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
