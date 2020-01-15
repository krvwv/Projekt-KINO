using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Projekt_KINO
{
    [Serializable]
    public class Rezerwacja
    {
        private string numerRezerwacji;
        private Seans seanse;
        private Widz widz;
        private DaneBiletu bilet;
        private static int numer;
        public string NumerRezerwacji { get => numerRezerwacji; set => numerRezerwacji = value; }
        public Seans Seans { get => seanse; set => seanse = value; }
        public Widz Widz { get => widz; set => widz = value; }
        public DaneBiletu Bilet { get => bilet; set => bilet = value; }
        public static int Numer { get => numer; set => numer = value; }
        static Rezerwacja()
        {
            Numer = 0;
        }
        public Rezerwacja()
        {

        }
        public Rezerwacja(Seans seans, Widz widz/* ,DaneBiletu bilet*/)
        {
            Numer++;
            NumerRezerwacji = "R" + Numer + "/" + DateTime.Now.Year;
            Seans = seans;
            Widz = widz;
            //Bilet = bilet;
            if(widz.Wiek<Seans.Film.OgraniczenieWiekowe)
            {
                throw new NieodpowiedniWiekException("Wiek widza jest nieodpowiedni dla tego filmu.");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nNumer rezerwacji: " + NumerRezerwacji);
            sb.AppendLine("Dane widza: " + widz.Login +" "+ widz.Haslo);
            sb.AppendLine("Dane filmu: " + Seans.Film.ToString());
            //sb.AppendLine("Koszt biletu: " + bilet.KosztBiletu());
            return sb.ToString();
        }
        public static Seans WybierzSeans(Kino k)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = "S/" + n.ToString() + "/" + "2020";
            Seans se = k.Seanse.Find(i => i.NumerSeansu == s);
            return se;
        }
        public static int WyborMiejsca(Seans s)
        {          
            int rzad, kolumna;
            Console.WriteLine("Dost�pne miejsca: ");
            Console.WriteLine(s.WszystkieMiejsca1.Length);
            for (int i = 0; i < s.WszystkieMiejsca1.GetLength(0); i++)
            {
                for (int j = 0; j < s.WszystkieMiejsca1.GetLength(1); j++)
                {
                    if (s.WszystkieMiejsca1[i, j] == false)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Podaj najpierw rz�d oraz zatwierd� a potem numer miejsca w rz�dzie");
            rzad = Convert.ToInt32(Console.ReadLine());
            kolumna = Convert.ToInt32(Console.ReadLine());
            if (s.WszystkieMiejsca1[rzad, kolumna] == false)
            {
                s.WszystkieMiejsca1[rzad, kolumna] = true;
                Console.WriteLine("Sukces!");
                return 1;
            }
            else
            {
                Console.WriteLine("Podane miejsce zosta�o ju� zarezerwowane, wbierz inne miejsce");
                return 0;
            }
        }
        

    }
}
