using System;
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
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();

            label_AnasayfaMessage.Text = "";
        }

        private void buttonAracGiris_Click(object sender, EventArgs e)
        {
            formAracGiris giris = new formAracGiris();
            giris.ShowDialog();
        }

        private void buttonAracCikis_Click(object sender, EventArgs e)
        {
            formAracCikis cikis = new formAracCikis();
            cikis.ShowDialog();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void buttonOtoparkDurumu_Click(object sender, EventArgs e)
        {
            formOtoparkDurumu otoparkDurumu = new formOtoparkDurumu();
            otoparkDurumu.ShowDialog();
        }

        private void buttonSatisListesi_Click(object sender, EventArgs e)
        {
            formSatis satis = new formSatis();
            satis.ShowDialog();
        }
    }
}
