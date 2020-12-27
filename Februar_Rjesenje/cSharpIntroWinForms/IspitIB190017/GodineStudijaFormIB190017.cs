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

namespace cSharpIntroWinForms.IspitIB190017
{
    public partial class GodineStudijaFormIB190017 : Form
    {
        bool modifikacija = false;
        GodineStudija godinaStudija = new GodineStudija();
        public GodineStudijaFormIB190017()
        {
            InitializeComponent();
            dgvGodineStudija.AutoGenerateColumns = false;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGodina.Text))
            {
                errNaziv.SetError(txtGodina, "Obavezno polje!");
                return;
            }
            if (!modifikacija)
            {
                foreach (var godina in DLWMS.DB.GodineStudija)
                    if (godina.Naziv == txtGodina.Text)
                    {
                        errNaziv.SetError(txtGodina, "Onemoguceno dodavanje istoimenih godina studija!");
                        return;
                    }
                var gs = new GodineStudija()
                {
                    Naziv = txtGodina.Text,
                    Aktivna = cbAktivna.Checked
                };
                DLWMS.DB.GodineStudija.Add(gs);
                DLWMS.DB.SaveChanges();
                UcitajGodineStudija();
            }
            else
            {
                foreach(var godina in DLWMS.DB.GodineStudija)
                {
                    if(godina.Id == godinaStudija.Id)
                    {
                        godina.Naziv = txtGodina.Text;
                        godina.Aktivna = cbAktivna.Checked;
                    }
                }
                DLWMS.DB.SaveChanges();
                modifikacija = false;
                UcitajGodineStudija();
            }
        }

        private void GodineStudijaFormIB190017_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
        }

        private void UcitajGodineStudija()
        {
            dgvGodineStudija.DataSource = null;
            dgvGodineStudija.DataSource = DLWMS.DB.GodineStudija.ToList();
        }

        private void dgvGodineStudija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var godina = dgvGodineStudija.SelectedRows[0].DataBoundItem as GodineStudija;
            txtGodina.Text = godina.Naziv;
            cbAktivna.Checked = godina.Aktivna;
            modifikacija = true;
            godinaStudija = godina;
        }
    }
}
