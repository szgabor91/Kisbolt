using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt
{
    class Vasarlas
    {
        public int vasarlasID, tetelID, termekID, mennyiseg;
        public string termekNev;

        public Vasarlas(int vasarlasID, int tetelID, 
            int termekID, int mennyiseg)
        {
            this.vasarlasID = vasarlasID;
            this.tetelID = tetelID;
            this.termekID = termekID;
            this.mennyiseg = mennyiseg;
        }

        public Vasarlas(int tetelID, int termekID, 
            string termekNev, int mennyiseg)
        {
            this.termekNev = termekNev;
            this.termekID = termekID;
            this.tetelID = tetelID;
            this.mennyiseg = mennyiseg;
        }

        public Vasarlas(int termekID, int mennyiseg)
        {
            this.termekID = termekID;
            this.mennyiseg = mennyiseg;
        }
    }
}
