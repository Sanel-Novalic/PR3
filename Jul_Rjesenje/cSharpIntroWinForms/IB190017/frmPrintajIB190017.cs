using Microsoft.Reporting.WinForms;
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
    public partial class frmPrintajIB190017 : Form
    {
        private List<Korisnik> lists;

        public frmPrintajIB190017()
        {
            InitializeComponent();
        }

        public frmPrintajIB190017(List<Korisnik> lists) : this()
        {
            this.lists = lists;
        }

        private void frmPrintajIB190017_Load(object sender, EventArgs e)
        {
            dtPolozeni.PolozeniDataTable tbl = new dtPolozeni.PolozeniDataTable();

            foreach(var korisnik in lists)
            {
                foreach(var polozeni in korisnik.Uspjeh)
                {
                    var red = tbl.NewPolozeniRow();
                    red.Ime = korisnik.Ime;
                    red.Prezime = korisnik.Prezime;
                    red.Ocjena = polozeni.Ocjena;
                    red.Datum = polozeni.Datum.ToString();
                    red.Predmet = polozeni.Predmet.Naziv;
                    tbl.AddPolozeniRow(red);
                }
            }
            var rds = new ReportDataSource();
            rds.Name = "dtPolozeni";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
