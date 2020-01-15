using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Projekt_KINO
{ 
    class Seans
    {
        private string numerSeansu;
        private DateTime data;
        private Sala sala;
        private Film film;
        private static int numer;
        private int iloscMiejsc;
        private int iloscMiejscWolnych;
        private bool[,] WszystkieMiejsca;
        public string NumerSeansu { get => numerSeansu; set => numerSeansu = value; }
        public DateTime Data { get => data; set => data = value; }
        internal Sala Sala { get => sala; set => sala = value; }
        internal Film Film { get => film; set => film = value; }
        public int IloscMiejsc { get => iloscMiejsc; set => iloscMiejsc = value; }
        public int IloscMiejscWolnych { get => iloscMiejscWolnych; set => iloscMiejscWolnych = value; }
        public bool[,] WszystkieMiejsca1 { get => WszystkieMiejsca; set => WszystkieMiejsca = value; }

        static Seans()
        {
            numer = 0;
        }
        public Seans(DateTime data, Sala sala, Film film)
        {
            IloscMiejsc = sala.Ilosc_miejsc;
            Data = data;
            Sala = sala;
            Film = film;
            NumerSeansu = "S/" + numer + "/" + data.Year;
            numer++;
            WszystkieMiejsca1 = new bool[Sala.IloscRzedow, Sala.IloscMiejscWRzedzie];
            WszystkieMiejsca1 = Sala.Miejsca();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numer seansu: " + NumerSeansu);
            sb.AppendLine("Data: " + Data);
            sb.AppendLine("Sala: " + Sala);
            sb.AppendLine("Film: " + Film);
            return sb.ToString();
        }
        

       /* public void WyborMiejsca()
        {
            int rzad, kolumna;
            Console.WriteLine("Dostępne miejsca: ");           
            Console.WriteLine(WszystkieMiejsca1.Length);
            for (int i = 0; i < WszystkieMiejsca1.GetLength(0); i++)
            {
                for (int j = 0; j <WszystkieMiejsca1.GetLength(1) ; j++)
                {
                    if (WszystkieMiejsca1[i, j] == false)
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
            Console.WriteLine("Podaj najpierw rząd oraz zatwierdź a potem numer miejsca w rzędzie");
            rzad = Convert.ToInt32(Console.ReadLine());
            kolumna= Convert.ToInt32(Console.ReadLine());
            if (WszystkieMiejsca1[rzad,kolumna]==false)
            {
                WszystkieMiejsca1[rzad, kolumna] = true;
                Console.WriteLine("Sukces!");

            }
            else
            {
                Console.WriteLine("Podane miejsce zostało już zarezerwowane, wbierz inne miejsce");
            }
        }*/
    }
}
