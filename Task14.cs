using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task14
    {
        public string testavaKuvaus = ("Tehtävä 14: Luo kaksi aliohjelmaa, joista toinen nimetään Nelio() ja toinen Tulosta(). Ne-lio() ottaa vastaan yhden luvun ja palauttaa luvun neliön.Tulosta ottaa vastaan merkki-jonon, jonka se tulostaa.Pääohjelmassa käyttäjältä kysytään, minkä luvun hän haluaa neliönä.Luku lähetetään Nelio()-aliohjelmaan, joka palauttaa luvun neliön. Vastaus tu-lostetaan käyttäen Tulosta()-funktiota.");

        // Otetaan c vastaan ja palautellaan sen neliöjuuri
        public double Nelio(double c)
        {
            return Math.Sqrt(c);
        }
        // Otetaan juuri vastaan ja tulostetaan se
        public void Tulosta(double juuri)
        {
            Console.WriteLine("Neliöjuuri on: " + juuri);
        }
    }
}
