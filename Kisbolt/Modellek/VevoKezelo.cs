using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kisbolt.Modellek
{
    class VevoKezelo:AbKezelo
    {
        private void HibaEllenorzes(Vevo vevo)
        {
            string hibak = "";
            if (vevo.vevoNev.Length < 3)
                hibak += "A vevő elnevezésének legalább 3 karakteresnek kell lennie! \n";
            if(vevo.vt.tipus != 1 && !Regex.IsMatch(vevo.adoszam, @"[\d]{8}(\-)[\d]{1}(\-)[\d]{2}"))
                hibak += "Az adószám formátuma nem megfelelő! \n";
            if (vevo.vt.tipus != 1 && vevo.szekhely.Length < 3)
                hibak += "A székhely mező csak a magánszemélyek esetében lehet üres! \n";

            if (hibak.Length > 0)
                throw new ArgumentException(hibak);
        }

        public void EllenorzottFelvitel(Vevo vevo)
        {
            HibaEllenorzes(vevo);
            VevoFelvitel(vevo);
        }

        public void EllenorzottFeluliras(Vevo vevo)
        {
            HibaEllenorzes(vevo);
            VevoFeluliras(vevo);
        }
    }
}
