using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using Microsoft.VisualStudio.Modeling.Diagrams;
namespace cSharpIntroWinForms.IB190017
{
    public partial class frmNovaPorukaIB190017 : Form
    {
        private KorisniciPoruke korisnik;
        private bool v=false;

        public frmNovaPorukaIB190017()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB190017(KorisniciPoruke korisnikPoruka, bool v = false) : this()
        {
            this.korisnik = korisnikPoruka;
            this.v = v;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null) return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            if (bytesArr == null) return null;
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(v)
            {
                if (string.IsNullOrEmpty(txtSadrzaj.Text))
                    errSadrzaj.SetError(txtSadrzaj, "Obavezno polje!");
                else
                {
                    korisnik.Korisnik.Poruke.Add(new KorisniciPoruke()
                    {
                        Korisnik = korisnik.Korisnik,
                        Datum = DateTime.Now.ToString(),
                        Sadrzaj = txtSadrzaj.Text,
                        Slika = ImageToByteArray(pbSlika.Image)
                    });
                    DLWMS.DB.SaveChanges();
                    MessageBox.Show("Uspjesno ste poslali poruku.");
                    Close();
                }
            }
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (!v) return;
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofd.FileName;
                Image slika = Image.FromFile(putanja);
                pbSlika.Image = slika;
            }
        }

        private void frmNovaPorukaIB190017_Load(object sender, EventArgs e)
        {
            if (!v)
                txtSadrzaj.ReadOnly = true;
            txtKorisnik.Text = $"{korisnik.Korisnik.ImePrezime()}";
            txtSadrzaj.Text = korisnik.Sadrzaj;
            pbSlika.Image = byteArrayToImage(korisnik.Slika);
        }
    }
}
