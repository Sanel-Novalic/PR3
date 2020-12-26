using cSharpIntroWinForms.P10;
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
    public partial class frmPorukeIB190017 : Form
    {
        private Korisnik korisnik;

        public frmPorukeIB190017()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmPorukeIB190017(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void frmPorukeIB190017_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = $"{korisnik.ImePrezime()}";
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = korisnik.Poruke;
        }

        private void dgvPoruke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnikPoruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPoruke;
            var poruka = new frmNovaPorukaIB190017(korisnikPoruka, false);
            poruka.ShowDialog();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var korisnikPoruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPoruke;
            var poruka = new frmNovaPorukaIB190017(korisnikPoruka, true);
            poruka.ShowDialog();
            UcitajPoruke();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var korisnik = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPoruke;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var jesiSiguran = new frmJesiSiguranIB190017();
                if(jesiSiguran.ShowDialog() == DialogResult.OK)
                {
                    korisnik.Sadrzaj = "";
                    UcitajPoruke();
                    DLWMS.DB.SaveChanges();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var printanje = new frmPrintajPorukeIB190017(korisnik);
            printanje.ShowDialog();
        }
    }
}
