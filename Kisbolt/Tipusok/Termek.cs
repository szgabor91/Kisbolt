using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt
{
    class Termek
    {
        public int termekID, ar, kategoriaID;
        public string termekNev, egyseg;

        public Termek(int ar, int kategoriaID, 
            string termekNev, string egyseg)
        {
            this.ar = ar;
            this.kategoriaID = kategoriaID;
            this.termekNev = termekNev;
            this.egyseg = egyseg;
        }

        public Termek(int termekID, int ar, int kategoriaID, 
            string termekNev, string egyseg)
        {
            this.termekID = termekID;
            this.ar = ar;
            this.kategoriaID = kategoriaID;
            this.termekNev = termekNev;
            this.egyseg = egyseg;
        }
    }
}
