using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    interface IKino
    {
        void DodajSeans(Seans s);
        void DodajSale(Sala s);
        void DodajFilm(Film f);
    }
}
