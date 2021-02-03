using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark.Sınıflar.Varliklar
{
    class Calisan
    {
        private int id;
        private string adi;
        private string soyadi;
        private string kAdi;
        private string parola;

        public int Id { get => id; set => id = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public string KAdi { get => kAdi; set => kAdi = value; }
        public string Parola { get => parola; set => parola = value; }
    }
}
