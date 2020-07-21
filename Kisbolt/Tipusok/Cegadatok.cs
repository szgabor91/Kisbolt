using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Tipusok
{
    class Cegadatok
    {
        public string felhNev, cegnev, adoszam, cegTipus;

        public Cegadatok(string felhNev, string cegnev, string adoszam, string cegTipus)
        {
            this.felhNev = felhNev;
            this.cegnev = cegnev;
            this.adoszam = adoszam;
            this.cegTipus = cegTipus;
        }
    }
}
