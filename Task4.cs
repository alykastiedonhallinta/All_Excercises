using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task4
    {
        string first = "Etunimi";
        string last = "Sukunimi";

        public string testavaKuvaus = ("Tehtävä 4: Yhdistä kaksi stringiä");

        // Luodaan aliohjelma stringien yhdistämistä varten
        public void Combine()
        {
            Console.WriteLine(first + " " + last);
        }
    }
}
