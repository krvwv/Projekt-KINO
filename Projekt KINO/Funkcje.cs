﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_KINO
{
    public class Funkcje
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
            Console.WriteLine("Masz już swoje konto? Jeśli tak wpisz 1 oraz zaakceptuj.\nJeżeli chcesz utworzyć konto wpisz 2");
            int wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor==1)
            {
                Widz w = Logowanie();
                return w;
            }
            else if(wybor==2)
            {
                Console.WriteLine("Podaj swój login, hasło oraz wiek");
                string login = Console.ReadLine();
                string haslo = Console.ReadLine();
                int wiek = Convert.ToInt32(Console.ReadLine());
                Widz widz = new Widz(login, haslo, wiek);
                Kino.DodajKlienta(widz);
                Console.WriteLine("Rejestracja zakończona powodzeniem!");
                return widz;
            }
            else
            {
                Console.WriteLine("Ups, coś poszło nie tak!");
                return null; //tutaj jeszcze dopisać powrót do ponownego wyboru
            }         
        }
       public static Widz Logowanie()
        {
            Widz w = new Widz();
            Console.WriteLine("Podaj login i hasło.");
            string login = Console.ReadLine();
            Widz widz =Kino.Klienci.Find(i => i.Login == login);
            string haslo = Console.ReadLine();
            if(widz!=null)
            {
                if(login!=widz.Login)
                {
                    Console.WriteLine("Nie ma użytkownika z takim loginem");
                    return null;
                }
                else if(haslo!=widz.Haslo)
                {
                    Console.WriteLine("Niepoprawne hasło.");
                    return null;
                }
                else
                {
                    Console.WriteLine("Zalogowano pomyślnie!");
                    return widz;
                }         
            }
            else
            {
                Console.WriteLine("Brak uzytkownika!");
                return null;
            }
        }

        public static void Serializuj(Rezerwacja r)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Rezerwacja));
            Stream streamer = new FileStream("rezerwacje.json", FileMode.Create);
            serializer.WriteObject(streamer, r);
            streamer.Close();
        }
        public static Rezerwacja Deserializuj()
        {
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Rezerwacja));
            Stream reader = new FileStream("rezerwacje.json", FileMode.Open);
            Object Wynik = deserializer.ReadObject(reader);
            reader.Close();
            return (Rezerwacja)Wynik;
        }
    }
}