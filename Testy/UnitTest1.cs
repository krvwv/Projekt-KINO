using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_KINO;
namespace Testy
{
    [TestClass]
    public class KinoTesty
    {
        [TestMethod]
        public void TworzenieKinaParametryczny()
        {
            Kino k1 = new Kino("MultiKino", "Kraków");
            Assert.AreEqual("MultiKino", k1.NazwaKina);
            Assert.AreEqual("Kraków", k1.Miasto);
        }
        [TestMethod]
        public void KinoSaleLicznik()
        {
            Kino CinemaCity = new Kino("CinemaCity", "Kraków");
            Sala sala1 = new Sala("1", 10, 2, 5);
            CinemaCity.DodajSale(sala1);
            Film spiderman = new Film("Spiderman", "Sam Raimi", 120, 16, Film.narracja.dubbing, Film.gatunki.akcja, czy_3D.nie);
            CinemaCity.DodajFilm(spiderman);
            Seans seans1 = new Seans(new DateTime(2020, 1, 20, 10, 30, 0), sala1, spiderman); //dodac sporo seansow
            CinemaCity.DodajSeans(seans1);
            Assert.AreEqual(1, CinemaCity.Seanse.Count);
            Assert.AreEqual(1, Kino.IloscSal);
        }
        [TestMethod]
        public void FilmParametryczny()
        {
            Film f1 = new Film("James Bond", "Sam Mendes", 148, 16, Film.narracja.napisy, Film.gatunki.akcja, czy_3D.nie);
            Assert.AreEqual(16, f1.OgraniczenieWiekowe);
        }
        [TestMethod]
        public void SalaParametryczny()
        {
            Sala s1 = new Sala("1", 40, 5, 8);
            Assert.AreEqual(40, s1.Ilosc_miejsc);
        }
        [TestMethod]
        public void WidzParametryczny()
        {
            Widz w1 = new Widz("mistrzunio", "qwe123", 20);
            Assert.AreEqual("mistrzunio", w1.Login);
        }


    }
}
