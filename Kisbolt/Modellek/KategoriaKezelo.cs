using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Modellek
{
    class KategoriaKezelo:AbKezelo
    {
        private void HibaKezelo(TermekKategoria kategoria)
        {
            if (kategoria.kategoriaNev.Length < 2)
                throw new ArgumentException("A kategória elnevezésének legalább 2 karakteresnek kell lennie!");
        }

        public void Felvitel(TermekKategoria kategoria)
        {
            HibaKezelo(kategoria);
            this.KategoriaFelvitel(kategoria);
        }

        public void Feluliras(TermekKategoria kategoria)
        {
            HibaKezelo(kategoria);
            this.KategoriaFeluliras(kategoria);
        }
    }
}
