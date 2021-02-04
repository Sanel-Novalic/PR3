using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; 

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            UcitajGodineStudija();
            UcitajAktivnost();
        }

        private void UcitajProsjek(List<Student> studenti)
        {
            double prosjek = 0;
            int brojac = 0;
            foreach (var student in studenti)
            {
                if (student.Prosjek() != -1)
                {
                    prosjek += student.Prosjek();
                    brojac++;
                }
            }
            if (brojac > 0)
            {
                lblProsjek.Text = $"Prosječna ocjena: {prosjek /= brojac}";
                lblBrojStudenata.Text = $"Broj studenata: {studenti.Count}";
            }
            else
            {
                lblProsjek.Text = "";
                lblBrojStudenata.Text = "";
            }
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
            
        }

        private void UcitajAktivnost()
        {
            cmbAktivnost.DataSource = new List<string>() { "SVI" , "Aktivni", "Neaktivni"};
        }

        private void UcitajGodineStudija()
        {
            cmbGodineStudija.DataSource = new List<string>() { "SVE" , "1", "2", "3", };
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
            UcitajProsjek(studenti ?? _baza.Studenti.ToList());
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }
        private bool PretragaStudenata(Student s)
        {
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private bool PretragaGodine(Student s)
        {
            return $"{s.GodinaStudija}" == cmbGodineStudija.Text || cmbGodineStudija.Text == "SVE";
        }

        private bool PretragaAktivnosti(Student s)
        {
            return s.Aktivan && cmbAktivnost.Text == "Aktivni" || !s.Aktivan && cmbAktivnost.Text == "Neaktivni" || cmbAktivnost.Text == "SVI";
        }
        void Filter()
        {
            UcitajPodatkeOStudentima(_baza.Studenti.ToList().Where(s => PretragaStudenata(s) && PretragaGodine(s) && PretragaAktivnosti(s)).ToList());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var print = new frmIzvjestaji(dgvStudenti.DataSource as List<Student>);
            print.ShowDialog();
        }
    }
}
