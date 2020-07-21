using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt
{
    class Raktar
    {
        public int raktarID;
        public Termek termek;
        public int mennyiseg;
        public int beszerzesiAr;
        public DateTime beszerzesiIdopont;

        public Raktar(int raktarID, Termek termek, 
            int mennyiseg, int beszerzesiAr, DateTime beszerzesiIdopont)
        {
            this.raktarID = raktarID;
            this.termek = termek;
            this.mennyiseg = mennyiseg;
            this.beszerzesiAr = beszerzesiAr;
            this.beszerzesiIdopont = beszerzesiIdopont;
        }

        public Raktar(Termek termek,int mennyiseg, 
            int beszerzesiAr, DateTime beszerzesiIdopont)
        {
            this.termek = termek;
            this.mennyiseg = mennyiseg;
            this.beszerzesiAr = beszerzesiAr;
            this.beszerzesiIdopont = beszerzesiIdopont;
        }
    }
}
