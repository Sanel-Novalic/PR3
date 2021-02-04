using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IB190017
{
    public partial class frmStudentiPotvrdeIB190017 : Form
    {
        public frmStudentiPotvrdeIB190017()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmStudentiPotvrdeIB190017_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }

        private void UcitajPotvrde()
        {
            dgvPotvrde.DataSource = null;
            dgvPotvrde.DataSource = DLWMSdb.Baza.StudentiPotvrde.ToList();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtGenerisi.Text);

            var random = new Random();
            int rand = random.Next(0, DLWMSdb.Baza.Studenti.ToList().Count - 1);
            Action action = () => UcitajPotvrde();
            await Task.Run(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    DLWMSdb.Baza.StudentiPotvrde.Add(new StudentiPotvrdeIB190017()
                    {
                        Student = DLWMSdb.Baza.Studenti.ToList().ElementAt(rand),
                        Svrha = "svrha",
                        Sadrzaj = "sadrzaj",
                        Datum = DateTime.Now.ToString(),
                        Izdata = false
                    });
                }
                DLWMSdb.Baza.SaveChanges();
                BeginInvoke(action);
            });
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajPotvrde();
            await Task.Run(() =>
            {
                if (MessageBox.Show(
                Poruke.DaLiSteSigurni,
                Poruke.Pitanje,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    foreach (var potvrda in DLWMSdb.Baza.StudentiPotvrde)
                    {
                        DLWMSdb.Baza.StudentiPotvrde.Remove(potvrda);
                    }
                    DLWMSdb.Baza.SaveChanges();
                    BeginInvoke(action);
                }
            });
        }

        public static void SaveCSV(string putanja) // Uzeo od Muhameda iz DelimiterDemo i malo pospremio
        {
            using (StreamWriter sw = File.AppendText(putanja))
            {
                foreach(var potvrda in DLWMSdb.Baza.StudentiPotvrde)
                {
                    sw.WriteLine(potvrda.Id + "," + potvrda.Student + "," + potvrda.Svrha + "," + potvrda.Sadrzaj + "," + potvrda.Datum + "," + potvrda.Izdata);
                }

                sw.Close();
            }
        }
        private void btnFajl_Click(object sender, EventArgs e)
        {
            SaveCSV(@"C:\Users\Kira\Downloads\Ispit_Template\DLWMS.WinForms\bin\Debug\StudentiPotvrdeIB190017.csv");
        }
    }
}
