using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    class Widz
    {
        private string login;
        private string haslo;
        private int wiek;       
        public int Wiek 
        {   get => wiek;
            set
            {
                if (value > 0)
                {
                    wiek = value;
                }
                else
                {
                    throw new Exception("Podany wiek jest nieprawidłowy!");
                }
            }
        }

        public string Login { get => login; set => login = value; }
        public string Haslo { get => haslo; set => haslo = value; }

        public Widz(string login, string haslo, int wiek)
        {
            Login = login;
            Haslo = haslo;
            Wiek = wiek;
        }

    }
}
