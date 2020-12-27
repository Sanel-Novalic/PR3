using cSharpIntroWinForms.P10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB190017
{
    public partial class KorisnikSlikePregled : Form
    {
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private Korisnik korisnik;

        int index = 0;
        public KorisnikSlikePregled()
        {
            InitializeComponent();
        }

        public KorisnikSlikePregled(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisnikSlikePregled_Load(object sender, EventArgs e)
        {
            UcitajSliku();
            
        }

        private void UcitajSliku()
        {
            if (korisnik.Slike.Count != 0)
                pbSlika.Image = byteArrayToImage(korisnik.Slike[0].Slika);
            else
                MessageBox.Show("Nemate postavljenu profilnu sliku.");
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                var putanja = ofd.FileName;
                Image slika = Image.FromFile(putanja);
                var ks = new KorisniciSlike()
                {
                    Korisnik = korisnik,
                    Slika = ImageToByteArray(slika)
                };
                korisnik.Slike.Add(ks);
                DLWMS.DB.SaveChanges();
            }
        }

        private void btnManji_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                pbSlika.Image = byteArrayToImage(korisnik.Slike[index-1].Slika);
                index--;
            }
            else
                MessageBox.Show("Ne postoji slika!");
        }

        private void btnVeci_Click(object sender, EventArgs e)
        {
            if (index < korisnik.Slike.Count - 1)
            {
                pbSlika.Image = byteArrayToImage(korisnik.Slike[index+1].Slika);
                index++;
            }
            else
                MessageBox.Show("Ne postoji slika!");
        }
    }
}
