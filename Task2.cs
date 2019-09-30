using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task2
    {
        // Luodaan muuttujat
        float a = 1.2f;
        float b = 1.234234234f;
        float c = 4.1234f;

        public string testavaKuvaus = ("Tehtävä 2: Luo kolme liukuluku muuttujaa, kerro kaksi ensimmäistä lukua keskenään ja jaa kerrottu luku kolmannella luvulla.Tulosta vastaus.");

        // Luodaan aliohjelma laskutoimitusta varten
        public void Calculate()
        {
            Console.WriteLine((a * b) / c);
        }

    }
}
