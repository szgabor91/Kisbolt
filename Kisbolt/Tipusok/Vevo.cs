using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt
{
    class Vevo
    {
        public int vevoID;
        public string vevoNev;
        public VevoTipus vt;
        public string adoszam;
        public string szekhely;
        public int aktiv;

        public Vevo(int vevoID, string vevoNev, VevoTipus vt,
            string adoszam, string szekhely, int aktiv)
        {
            this.vevoID = vevoID;
            this.vevoNev = vevoNev;
            this.vt = vt;
            this.adoszam = adoszam;
            this.szekhely = szekhely;
            this.aktiv = aktiv;
        }

        public Vevo(string vevoNev, VevoTipus vt,
            string adoszam, string szekhely, int aktiv)
        {
            this.vevoNev = vevoNev;
            this.vt = vt;
            this.adoszam = adoszam;
            this.szekhely = szekhely;
            this.aktiv = aktiv;
        }
    }
}
