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
    public partial class frmPrintajPorukeIB190017 : Form
    {
        private Korisnik korisnik;

        public frmPrintajPorukeIB190017()
        {
            InitializeComponent();
        }

        public frmPrintajPorukeIB190017(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void frmPrintajPorukeIB190017_Load(object sender, EventArgs e)
        {
            dtPrintajIB190017.PorukeDataTable tbl = new dtPrintajIB190017.PorukeDataTable();

            foreach(var poruka in korisnik.Poruke)
            {
                var red = tbl.NewPorukeRow();
                red.Datum = poruka.Datum;
                red.Sadrzaj = poruka.Sadrzaj;
                red.Slika = poruka.Slika;
                tbl.AddPorukeRow(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dtPoruke";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
