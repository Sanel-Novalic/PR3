using cSharpIntroWinForms.IB190017;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbSpolovi.DataSource = konekcijaNaBazu.Spolovi.ToList();
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            var filter = txtPretraga.Text.ToLower() ;
            var spol = cmbSpolovi.SelectedItem as Spolovi;
            var korisnici = new List<Korisnik>();
            foreach(var korisnik in konekcijaNaBazu.Korisnici)
            {
                if ((korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter)) && cbAdministrator.Checked == korisnik.Admin
                    && (spol.Id == korisnik.Spol.Id || spol.Naziv == "<NOT SET>"))
                    korisnici.Add(korisnik);
            }
            LoadData(korisnici);
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var printaj = new frmPrintajIB190017(dgvKorisnici.DataSource as List<Korisnik>);
            printaj.ShowDialog();
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var ks = new KorisnikSlikePregled(korisnik);
                ks.ShowDialog();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int n = int.Parse(txtThread.Text);
            var sumiranje = Task.Run(() =>
            {
                for (int i = 1; i <= n; i++)
                {
                    suma += i;
                }
            });
            var cekanje = sumiranje.GetAwaiter();
            cekanje.OnCompleted(() =>
            {
                MessageBox.Show($"Suma od 1 do {n} je: {suma}");
            });
        }
    }
}
