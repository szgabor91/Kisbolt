using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Modellek
{
    class RaktarKezelo:AbKezelo
    {
        private void Hibaellenorzes(Raktar raktar)
        {
            string hibak = "";

            if (raktar.termek.termekID == 0)
                hibak += "Ki kell választani egy terméket! \n";

            if (raktar.beszerzesiAr < 1)
                hibak += "A beszerzési ár nem lehet kisebb, mint 1 Ft!";

            if (raktar.mennyiseg < 1)
                hibak += "A mennyiség nem lehet kisebb, mint 1 darab.";

            if (raktar.beszerzesiIdopont > DateTime.Now)
                hibak += "A beszerzési időpont nem lehet későbbi, mint a mai dátum!";

            if (hibak.Length > 0)
                throw new ArgumentException(hibak);
        }

        public void EllenorzottFelvitel(Raktar raktar)
        {
            this.Hibaellenorzes(raktar);

            this.RaktarFelvitel(raktar);
        }

        public void EllenorzottFeluliras(Raktar raktar)
        {
            this.Hibaellenorzes(raktar);

            this.RaktarFeluliras(raktar);
        }
    }
}
