using cSharpIntroWinForms.IspitIB190017;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajOcjene();
            UcitajPolozenePredmete();
            UcitajGodineStudija();
        }

        private void UcitajGodineStudija()
        {
            cmbGodineStudija.DataSource = konekcijaNaBazu.GodineStudija.ToList();
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.ToList();
        }

        private void UcitajOcjene()
        {
            var ocjene = new List<int>()
            {
                6,
                7,
                8,
                9,
                10
            };
            cmbOcjene.DataSource = ocjene;
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = null;
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            var godina = cmbGodineStudija.SelectedItem as GodineStudija;

            foreach (var polozeni in korisnik.Uspjeh)
            {
                if (polozeni.Predmet.Naziv == predmet.Naziv && godina.Id == polozeni.Godina.Id)
                {
                    errDodaj.SetError(btnDodajPolozeni, "Onemoguceno dodavanje istoimenih predmeta na istoj godini studija!");
                    return;
                }
            }
            var kp = new KorisniciPredmeti()
            {
                Korisnik = korisnik,
                Datum = dtpDatumPolaganja.Value.ToString(),
                Ocjena = int.Parse(cmbOcjene.Text),
                Predmet=predmet,
                Godina=godina
            };
            korisnik.Uspjeh.Add(kp);
            konekcijaNaBazu.SaveChanges();
            UcitajPolozenePredmete();
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var u = new frmUvjerenjeIB190017(korisnik);
            u.ShowDialog();
        }
    }
}
