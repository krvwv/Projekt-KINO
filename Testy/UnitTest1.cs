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
           
        }
    }
}
