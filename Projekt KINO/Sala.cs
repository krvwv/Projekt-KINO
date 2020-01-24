    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    [Serializable]
    public class Sala:ICloneable
    {
        private string NumerSali;
        private int IloscMiejsc;
        private int iloscRzedow;
        private int iloscMiejscWRzedzie;
        private bool[,] miejsca;
        public string Numer_sali { get => NumerSali; set => NumerSali = value; }
        public int Ilosc_miejsc 
        {   get => IloscMiejsc;
            set
            {
                if (value > 0)
                {
                    IloscMiejsc = value;
                }
                else
                {
                    throw new Exception("Podana ilość miejsc jest nieprawidłowa!");
                }
            }
        }
        public int IloscRzedow { get => iloscRzedow; set => iloscRzedow = value; }
        public int IloscMiejscWRzedzie { get => iloscMiejscWRzedzie; set => iloscMiejscWRzedzie = value; }
        public bool[,] Miejsca1 { get => miejsca; set => miejsca = value; }

        public Sala()
        {

        }
        public Sala(string NumerSali, int IloscMiejsc, int iloscRzedow, int iloscMiejscWRzedzie)
        {
            this.NumerSali = NumerSali;
            Ilosc_miejsc = IloscMiejsc;
            IloscRzedow = iloscRzedow;
            IloscMiejscWRzedzie = iloscMiejscWRzedzie;
            Miejsca1 = new bool[IloscRzedow,IloscMiejscWRzedzie];
        }
        public override string ToString()
        {
            /*StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nNumer sali: " + Numer_sali);*/
            return Numer_sali;
        }
        public bool[,] Miejsca()
        {
            int k = 0;
            for (int i = 0; i < IloscRzedow; i++)
            {
                for (int j = 0; j < IloscMiejscWRzedzie; j++)
                {
                    Miejsca1[i, j] = false;
                    k++;
                }
            }
            return Miejsca1;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
