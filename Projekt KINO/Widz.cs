using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    [Serializable]
    public class Widz:IEquatable<Widz>
    {
        
        private string login;
        private string haslo;
        private int wiek;
        private List<Rezerwacja> rezerwacje;
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
        public List<Rezerwacja> Rezerwacje { get => rezerwacje; set => rezerwacje = value; }
      

        public Widz()
        {
      
        }
        public Widz(string login, string haslo, int wiek)
        {
            Login = login;
            Haslo = haslo;
            Wiek = wiek;
            Rezerwacje = new List<Rezerwacja>();            
        }
        public void DodajRezerwacje(Rezerwacja r)
        {
            Rezerwacje.Add(r);
        }
        public void PokazRezerwacje()
        {
            foreach (Rezerwacja r in Rezerwacje)
            {
                Console.WriteLine(r);
            }
        }

        public bool Equals(Widz other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.Login == other.Login)
            {
                return true;
            }
            else
            {
                return false;
            }
            //   throw new NotImplementedException();
        }
    }
}
