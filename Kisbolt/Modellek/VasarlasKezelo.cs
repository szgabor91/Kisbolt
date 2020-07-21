using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Modellek
{
    class VasarlasKezelo:AbKezelo
    {
        private void HibaEllenorzes(Vasarlas vasarlas)
        {
            
        }

        public void EllenorzottFelvitel(List<Vasarlas> vasarlasLista, int vevoID)
        {
            Vasarlas(vasarlasLista, vevoID);
        }

        public void EllenorzottFeluliras(List<Vasarlas> vasarlasLista)
        {

        }
    }
}
