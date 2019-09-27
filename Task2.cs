using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 2: Luo kolme liukuluku muuttujaa, kerro kaksi ensimmäistä lukua keskenään ja jaa kerrottu luku kolmannella luvulla.Tulosta vastaus.
    public class Task2
    {
        float a = 1.2f;
        float b = 1.234234234f;
        float c = 4.1234f;

        public void Calculate()
        {
            Console.WriteLine((a * b) / c);
        }

    }
}
