using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB190017
{
    public class KorisniciSlike
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        public byte[] Slika { get;set; }
    }
}
