using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_KINO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*//Kino
            Kino CinemaCity = new Kino("CinemaCity", "Kraków");

            //Sala
            Sala sala1 = new Sala("1", 10, 2, 5);
            Sala sala2 = new Sala("2", 20, 4, 5);
            CinemaCity.DodajSale(sala1);
            CinemaCity.DodajSale(sala2);
            sala2.Miejsca();
            //Film
            Film spiderman = new Film("Spiderman", "Sam Raimi", 120, 16, Film.narracja.dubbing, Film.gatunki.akcja,czy_3D.nie);
            Film thor = new Film("Thor", "Kenneth Branagh", 114, 12, Film.narracja.dubbing, Film.gatunki.akcja,czy_3D.nie);
            CinemaCity.DodajFilm(spiderman);
            CinemaCity.DodajFilm(thor);
            //Console.WriteLine(CinemaCity);
            //Seans
            Seans seans1 = new Seans(new DateTime(2020, 1, 20, 10, 30, 0), sala1, spiderman); //dodac sporo seansow
            Seans seans2 = new Seans(new DateTime(2020, 1, 20, 10, 30, 0), sala2, thor);
            CinemaCity.DodajSeans(seans1);
            CinemaCity.DodajSeans(seans2);*/
            #endregion
            Kino CinemaCity = Funkcje.InizjalizacjaKina();
            Menu menu = new Menu();
            Widz w = new Widz();
            int wybor;
            do
            {
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        CinemaCity.PokazFilmy();
                        Menu.PokazMenu();
                        break;
                    case 2:
                        CinemaCity.PokazSeanse();
                        Menu.PokazMenu();
                        break;
                    case 3:
                        Widz widz = Funkcje.Uzytkownik();
                        if(widz!=null)
                        {                           
                            
                            Console.WriteLine("Wybierz numer seansu, na który chcesz się wybrać: ");
                            Seans zarezerwowany = Rezerwacja.WybierzSeans(CinemaCity);
                            //Rezerwacja.WyborMiejsca(zarezerwowany); 
                            if (Rezerwacja.WyborMiejsca(zarezerwowany) == 1)
                            {
                                Rezerwacja r = new Rezerwacja(zarezerwowany, widz);
                                widz.DodajRezerwacje(r);
                                //tutaj jakas serializacja do xmla ale array nie chce przejsc to trzeba jakos obejsc mądrze
                            }
                            else
                            {
                                Console.WriteLine("Próba rezerwacji nie powiodła się.");
                            }
                            widz.PokazRezerwacje();
                        }
                        else
                        {
                            Console.WriteLine("BŁĄD");
                        }
                       
                        //Menu.PokazMenu();
                        break;
                    case 4:
                        //do tego trzeba sie zalogowac i potem pokazac rezerwacje
                        Console.WriteLine("Zaloguj się na swoje konto by zobaczyć rezerwacje");
                        Widz widz4 = Funkcje.Logowanie();
                        widz4.PokazRezerwacje();
                        break;
                    case 5:
                        wybor = 666;
                        Console.WriteLine("Do zobaczenia! :)");                     
                        break;
                    default:
                        Console.WriteLine("Ups, coś poszło nie tak, wpisz numer jeszcze raz!");
                        break;
                }
            } 
            while (wybor != 666);
            
            Console.ReadKey();
        }
    }
}
