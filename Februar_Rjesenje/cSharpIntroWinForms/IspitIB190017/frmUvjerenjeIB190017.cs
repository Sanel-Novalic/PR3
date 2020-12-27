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

namespace cSharpIntroWinForms.IspitIB190017
{
    public partial class frmUvjerenjeIB190017 : Form
    {
        private Korisnik korisnik;

        public frmUvjerenjeIB190017()
        {
            InitializeComponent();
        }

        public frmUvjerenjeIB190017(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void frmUvjerenjeIB190017_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime",$"{korisnik.Ime} {korisnik.Prezime}"));
            var tbl = new dtPolozeni.PolozeniDataTable();
            foreach(var polozeni in korisnik.Uspjeh)
            {
                var red = tbl.NewPolozeniRow();
                red.Predmet = polozeni.Predmet.Naziv;
                red.Datum = polozeni.Datum;
                red.Godina = polozeni.Godina.Naziv;
                red.Ocjena = polozeni.Ocjena;
                tbl.AddPolozeniRow(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dtPolozeni";
            rds.Value = tbl;
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
