using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Kivetelek
{
    class AutentikacioKivetel:Exception
    {
        public AutentikacioKivetel(string message):base(message)
        {

        }

    }
}
