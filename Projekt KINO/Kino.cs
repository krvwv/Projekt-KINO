using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    public enum czy_3D { tak, nie };
    class Kino
    {
        private string nazwaKina;
        private string miasto;
        private static int iloscSal;
        private List<Film> filmy;
        private List<Sala> sale;
        private List<Seans> seanse;

        public string NazwaKina { get => nazwaKina; set => nazwaKina = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public static int IloscSal { get => iloscSal; set => iloscSal = value; }
        internal List<Film> Filmy { get => filmy; set => filmy = value; }
        public List<Seans> Seanse { get => seanse; set => seanse = value; }

        static Kino()
        {
            iloscSal = 0;
        }
        public Kino(string NazwaKina, string Miasto)
        {
            this.NazwaKina = NazwaKina;
            this.Miasto = Miasto;
            sale = new List<Sala>();
            filmy = new List<Film>();
            Seanse = new List<Seans>();
        }
        public void DodajSeans(Seans s)
        {
            Seanse.Add(s);
        }

        public void DodajSale(Sala s)
        {
            sale.Add(s);
            IloscSal++;
        }
        public void DodajFilm(Film f)
        {
            filmy.Add(f);
        }
        public void PokazFilmy()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nObecnie grane filmy: ");
            if (filmy.Count>0)
            {
                foreach (Film f in filmy)
                {
                    sb.AppendLine(f.ToString());
                }
            }
            else
            {
                sb.AppendLine("\nObecnie nie są grane żadne filmy w tym kinie.");
            }
            Console.WriteLine(sb);
        }
        public void PokazSeanse()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nAktualne seanse: ");
            if (Seanse.Count > 0)
            {
                foreach (Seans s in Seanse)
                {
                    sb.AppendLine(s.ToString());
                }
            }
            else
            {
                sb.AppendLine("\nBrak seansów.");
            }
            Console.WriteLine(sb);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nNazwa kina: " + NazwaKina);
            sb.AppendLine("\nMiasto: " + Miasto);
            sb.AppendLine("\nIlość sal: " + IloscSal);
            sb.AppendLine("\nObecnie grane filmy: ");
            if (filmy.Count() > 0)
            {
                foreach (Film f in filmy)
                {
                    sb.AppendLine(f.ToString());
                }
            }
            else
            {
                sb.AppendLine("\nObecnie nie są grane żadne filmy w tym kinie.");
            }
            return sb.ToString();
        }

    }
}
