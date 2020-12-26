using cSharpIntroWinForms.P10;
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

namespace cSharpIntroWinForms.IB190017
{
    public partial class frmPretragaBrojIndeksa_IB190017 : Form
    {
        public frmPretragaBrojIndeksa_IB190017()
        {
            InitializeComponent();
            dgvKorisniciPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretragaBrojIndeksa_IB190017_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            var filter = txtNaziv.Text;
            var korisniciPredmeti = new List<KorisniciPredmeti>();
            foreach(var korisnik in DLWMS.DB.KorisniciPredmeti)
            {
                if(korisnik.Predmet.Naziv.Contains(filter))
                {
                    korisniciPredmeti.Add(korisnik);
                }
            }
            dgvKorisniciPredmeti.DataSource = null;
            dgvKorisniciPredmeti.DataSource = korisniciPredmeti;
            lblProsjek.Text = $"Prosjek prikazanih ocjena: {Prosjek(korisniciPredmeti).ToString()}";
        }

        private float Prosjek(List<KorisniciPredmeti> korisniciPredmeti)
        {
            float rezultat = korisniciPredmeti.Sum(x => x.Ocjena);
            if (korisniciPredmeti.Count == 0)
                return 0;
            return rezultat / korisniciPredmeti.Count;
        }

        private void dgvKorisniciPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var korisnikPredmet = dgvKorisniciPredmeti.SelectedRows[0].DataBoundItem as KorisniciPredmeti;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var poruka = new frmPorukeIB190017(korisnikPredmet.Korisnik);
                poruka.ShowDialog();

            }
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int n = int.Parse(txtThread.Text);
            var sumiranje = Task.Run(() =>
           {
               for (int i = 1; i <= n; i++)
                   suma += i;
           });
            var cekanje = sumiranje.GetAwaiter();
            cekanje.OnCompleted(() =>
            {
                lblSuma.Text = "Suma je: ";
                lblRezultat.Text = $"{suma}";
            });
        }
    }
}
