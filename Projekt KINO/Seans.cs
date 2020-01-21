using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Projekt_KINO
{ 
    [Serializable]
    public class Seans
    {
        private string numerSeansu;
        private DateTime data;
        private Sala sala;
        private Film film;
        private static int numer;
        private int iloscMiejsc;
        private bool[,] WszystkieMiejsca;
        public string NumerSeansu { get => numerSeansu; set => numerSeansu = value; }
        public DateTime Data { get => data; set => data = value; }
        public Sala Sala { get => sala; set => sala = value; }
       public Film Film { get => film; set => film = value; }
        public int IloscMiejsc { get => iloscMiejsc; set => iloscMiejsc = value; }
        internal bool[,] WszystkieMiejsca1 { get => WszystkieMiejsca; set => WszystkieMiejsca = value; }

        static Seans()
        {
            numer = 0;
        }
        public Seans()
        {

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
        
    }
}
