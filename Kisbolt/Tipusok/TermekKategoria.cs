using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt
{
    class TermekKategoria
    {
        public int kategoriaID;
        public string kategoriaNev;

        public TermekKategoria(string kategoriaNev)
        {
            this.kategoriaNev = kategoriaNev;
        }

        public TermekKategoria(int kategoriaID, string kategoriaNev)
        {
            this.kategoriaNev = kategoriaNev;
            this.kategoriaID = kategoriaID;
        }
    }
}
