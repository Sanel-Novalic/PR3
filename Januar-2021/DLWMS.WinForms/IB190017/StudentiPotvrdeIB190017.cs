using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB190017
{
    public class StudentiPotvrdeIB190017
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public string Svrha { get; set; }
        public string Sadrzaj { get; set; }
        public string Datum { get; set; }

        public bool Izdata { get; set; }
    }
}
