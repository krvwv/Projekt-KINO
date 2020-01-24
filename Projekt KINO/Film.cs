using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    [Serializable]
    public class Film
    {
        public enum narracja { napisy, dubbing};
        public enum gatunki { komedia, romans, horror, dramat, thriller, akcja, kryminał, dokument}
        private string tytul;
        private string rezyser;
        private int czasTrwania;
        private int ograniczenieWiekowe;
        private narracja rodzajNarracji;
        private gatunki gatunek;
        private czy_3D threedimensions;

        public string Tytul { get => tytul; set => tytul = value; }
        public string Rezyser { get => rezyser; set => rezyser = value; }
        public int CzasTrwania { get => czasTrwania; set => czasTrwania = value; }
        public int OgraniczenieWiekowe 
        {   get => ograniczenieWiekowe;
            set
            {
                if (value > 0)
                {
                    ograniczenieWiekowe = value;
                }
                else
                {
                    throw new Exception("Podana ograniczenie jest nieprawidłowe!");
                }
            }
        }
        public narracja RodzajNarracji { get => rodzajNarracji; set => rodzajNarracji = value; }
        public gatunki Gatunek { get => gatunek; set => gatunek = value; }
        public czy_3D Threedimensions { get => threedimensions; set => threedimensions = value; }

        public Film()
        {

        }
        public Film(string Tytul, string Rezyser, int CzasTrwania, int OgraniczenieWiekowe, narracja RodzajNarracji, gatunki Gatunek,czy_3D td)
        {
            this.Tytul = Tytul;
            this.Rezyser = Rezyser;
            this.CzasTrwania = CzasTrwania;
            this.OgraniczenieWiekowe = OgraniczenieWiekowe;
            this.RodzajNarracji = RodzajNarracji;
            this.Gatunek = Gatunek;
            Threedimensions = td;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nTytuł: " + Tytul);
            sb.AppendLine("Reżyser: " + rezyser);
            sb.AppendLine("Czas trwania: " + czasTrwania+" minut");
            sb.AppendLine("Ograniczenie wiekowe: " + ograniczenieWiekowe);
            sb.AppendLine("Rodzaj narracji: " + RodzajNarracji);
            sb.AppendLine("Gatunek: " + Gatunek);
            sb.AppendLine("3D: " + Threedimensions);
            return sb.ToString();
        }

    }
}
