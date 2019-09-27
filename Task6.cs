using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 6: Luo merkkijono, jonka arvoksi asetat ”------Tutkimus,,,, ja kehitys------”. Poista merkkijonosta ylimääräiset kirjaimet ja tulosta vastaus.*/
    public class Class1
    {
        string tki = "------Tutkimus,,,, ja kehitys------";

        public void replaceThings()
        {
            Console.WriteLine(tki.Replace("-", "").Replace(",", ""));
        }
    }
}
