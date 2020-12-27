using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IspitIB190017
{
    public partial class GlavnaIB190017 : Form
    {
        public GlavnaIB190017()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            var gs = new GodineStudijaFormIB190017();
            gs.ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {
            var korisnik = DLWMS.DB.Korisnici.ToList().First();
            var kpp = new KorisniciPolozeniPredmeti(korisnik);
            kpp.ShowDialog();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThread.Text))
                return;
            int n = int.Parse(txtThread.Text);
            int suma = 0;
            var sumiranje = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                    suma += i;
            });
            var cekanje = sumiranje.GetAwaiter();
            cekanje.OnCompleted(() => {
                MessageBox.Show($"Suma od 1 do {n} je: {suma}");
            });
        }
    }
}
