using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kisbolt.Kivetelek;
using Kisbolt.Tipusok;

namespace Kisbolt.Modellek
{
    class FelhasznaloKezelo:AbKezelo
    {
        public static bool Elfogadva
        {
            get;
            private set;
        }

        public FelhasznaloKezelo()
        {
            Elfogadva = false;
        }

        public Cegadatok Beleptetes(string felh, string jelsz)
        {
            Cegadatok cegadatok = this.Bejelentkezes(felh, jelsz);

            if(cegadatok.adoszam.Length > 0)
            {
                Elfogadva = true;
            }
            else
            {
                throw new AutentikacioKivetel("Nem megfelelő felhasználónév/jelszó páros!");
            }
            return cegadatok;
        }
    }
}
