using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    class Funkcje
    {
        public static Kino InizjalizacjaKina()
        {
            //Kino
            Kino CinemaCity = new Kino("CinemaCity", "Kraków");
            //Sala
            Sala sala1 = new Sala("1", 10, 2, 5);
            Sala sala2 = new Sala("2", 20, 4, 5);
            CinemaCity.DodajSale(sala1);
            CinemaCity.DodajSale(sala2);
            sala2.Miejsca();
            //Film
            Film spiderman = new Film("Spiderman", "Sam Raimi", 120, 16, Film.narracja.dubbing, Film.gatunki.akcja, czy_3D.nie);
            Film thor = new Film("Thor", "Kenneth Branagh", 114, 12, Film.narracja.dubbing, Film.gatunki.akcja, czy_3D.nie);
            CinemaCity.DodajFilm(spiderman);
            CinemaCity.DodajFilm(thor);
            //Console.WriteLine(CinemaCity);
            //Seans
            Seans seans1 = new Seans(new DateTime(2020, 1, 20, 10, 30, 0), sala1, spiderman); //dodac sporo seansow
            Seans seans2 = new Seans(new DateTime(2020, 1, 20, 10, 30, 0), sala2, thor);
            CinemaCity.DodajSeans(seans1);
            CinemaCity.DodajSeans(seans2);

            return CinemaCity;
        }
        public static Widz Uzytkownik()
        {
            Widz def = new Widz("DEF", "DEF", 20);
            Console.WriteLine("Masz już swoje konto? Jeśli tak wpisz 1 oraz zaakceptuj.\nJeżeli chcesz utworzyć konto wpisz 2");
            int wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor==1)
            {
                //logowanie
                return def;
            }
            else if(wybor==2)
            {
                Console.WriteLine("Podaj swój login, hasło oraz wiek");
                string login = Console.ReadLine();
                string haslo = Console.ReadLine();
                int wiek = Convert.ToInt32(Console.ReadLine());
                Widz widz = new Widz(login, haslo, wiek);
                Console.WriteLine("Rejestracja zakończona powodzeniem!");
                return widz;
            }
            else
            {
                Console.WriteLine("Ups, coś poszło nie tak!");
                return def; //tutaj jeszcze dopisać powrót do ponownego wyboru
            }
            
        }

    }
}
