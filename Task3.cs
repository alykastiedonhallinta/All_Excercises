using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task3
    {
        string omaNimi = "Etunimi";

        public string testavaKuvaus = ("Tehtävä 3: Luo merkkijono muuttuja omaNimi, jonka arvoksi laitat oman etunimesi.Tämän jälkeen tulosta tervehdys omaNimi muuttujan kanssa.");

        // Luodaan aliohjelma stringien ynnäämistä varten
        public void Combine()
        {
            Console.WriteLine("Tervehdys " + omaNimi);
        }
    }
}
