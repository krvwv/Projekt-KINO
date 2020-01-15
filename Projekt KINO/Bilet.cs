using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    class Bilet : DaneBiletu
    {
        public enum znizki { uczen, student, senior, normalny };
        private znizki znizka;

        internal znizki Znizka { get => znizka; set => znizka = value; }

        public Bilet(double cenaBiletu, znizki znizka) : base(cenaBiletu)
        {
            Znizka = znizka;
        }

        public override double KosztBiletu()
        {
            if (znizka == znizki.uczen)
            {
                return base.KosztBiletu() * 0.5;
            }
            else if (znizka == znizki.student)
            {
                return base.KosztBiletu() * 0.6;
            }
            else if (znizka == znizki.senior)
            {
                return base.KosztBiletu() * 0.7;
            }
            return base.KosztBiletu();
        }
    }
}
