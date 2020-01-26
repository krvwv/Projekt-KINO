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
                            if (Rezerwacja.WyborMiejsca(zarezerwowany) == 1)
                            {
                                Rezerwacja r = new Rezerwacja(zarezerwowany, widz);
                                widz.DodajRezerwacje(r);
                                widz.PokazRezerwacje();
                                Console.WriteLine("Sukces!");
                            }
                            else
                            {
                                Console.WriteLine("Próba rezerwacji nie powiodła się.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("BŁĄD");
                        }
                        
                        Menu.PokazMenu();
                        break;
                    case 4:
                        Console.WriteLine("Zaloguj się na swoje konto by zobaczyć rezerwacje");
                        Widz widz4 = Funkcje.Logowanie();
                        if (widz4!=null)
                        {
                            widz4.PokazRezerwacje();
                        }
                        else
                        {
                            Console.WriteLine("Brak widza o podanych danych.");
                        }
                        Menu.PokazMenu();
                        break;
                    case 5:
                        wybor = 666;
                        Funkcje.SerializujWidzow();
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
