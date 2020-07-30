using Kisbolt.Kivetelek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Tipusok
{
    class Cegadatok
    {
        private string felhNev, cegnev, adoszam, cegTipus;

        public Cegadatok(string felhNev, string cegnev, string adoszam, string cegTipus)
        {
            this.felhNev = felhNev;
            this.cegnev = cegnev;
            this.adoszam = adoszam;
            this.cegTipus = cegTipus;

            if (felhNev == null) { throw new ArgumentNullException(felhNev); }
            if (cegnev == null) { throw new ArgumentNullException(cegnev); }
            if (adoszam == null) { throw new ArgumentNullException(adoszam); }
            if (cegTipus == null) { throw new ArgumentNullException(cegTipus); }
        }

        public string GetFelhNev()
        {
            return felhNev;
        }

        public string GetCegnev()
        {
            return cegnev;
        }

        public string GetAdoszam()
        {
            return adoszam;
        }

        public string GetTipus()
        {
            return cegTipus;
        }
    }
}
