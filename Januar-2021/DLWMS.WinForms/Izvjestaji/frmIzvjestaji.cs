using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> lists;

        private int brojac = 1;
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<Student> lists) : this()
        {
            this.lists = lists;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsDLWMS.PredmetiDataTable();
            foreach(var s in lists)
            {
                var red = tbl.NewPredmetiRow();
                red.Rb = brojac++;
                red.Indeks = s.Indeks;
                red.Ime = s.Ime;
                red.Prezime = s.Prezime;
                red.GodinaStudija = s.GodinaStudija;
                red.Aktivan = s.Aktivan;
                tbl.AddPredmetiRow(red);
            }
            rds.Name = "dsDLWMS";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
