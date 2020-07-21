using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Modellek
{
    class TermekKezelo:AbKezelo
    {
        private void HibaKezelo(Termek termek)
        {
            string hibak = "";

            if (termek.ar < 0)
                hibak += "Az ár nem lehet kisebb, mint 0 ft. \n";
            if (termek.termekNev.Length < 3)
                hibak += "A terméknévnek legalább 3 karakteresnek kell lennie\n";
            if (termek.kategoriaID == 0)
                hibak += "Ki kell választani egy termékkategóriát!\n";
            if (termek.egyseg.Length == 0)
                hibak += "Ki kell választani a termék egységet! \n";

            if (hibak.Length > 0)
                throw new ArgumentException(hibak);
        }

        public void Felvitel(Termek termek)
        {
            HibaKezelo(termek);

            this.TermekFelvitel(termek);
        }

        public void Feluliras(Termek termek)
        {
            HibaKezelo(termek);

            this.TermekFeluliras(termek);
        }
    }
}
