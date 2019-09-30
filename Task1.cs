using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task1
    {
        // Luodaan muuttujat
        int a = 1;
        int b = 2;

        public string testavaKuvaus = ("Tehtävä 1: Luo kaksi kokonaisluku muuttujaa ja tulosta muuttujien summa.");

        // Luodaan aliohjelma yhteenlaskua varten
        public void Calculate()
        {
            Console.WriteLine(a + b);
        }
    }
}
