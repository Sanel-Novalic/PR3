using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IspitIB190017
{
    public class GodineStudija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivna { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
