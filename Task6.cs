using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task6
    {
        string tki = "------Tutkimus,,,, ja kehitys------";

        public string testavaKuvaus = ("Tehtävä 6: Luo merkkijono, jonka arvoksi asetat ”------Tutkimus,,,, ja kehitys------”. Poista merkkijonosta ylimääräiset kirjaimet ja tulosta vastaus.");

        public void replaceThings()
        {
            // Korvataan - ja , merkit tyhjillä
            Console.WriteLine(tki.Replace("-", "").Replace(",", ""));
        }
    }
}
