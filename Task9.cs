using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 9: Luo ohjelma, joka kysyy käyttäjältä nimen, osoitteen ja puhelinnumeron.Tulosta käyttäjän syöttämät tiedot.
    public class Task9
    {
        public void askInfo()
        {
            Console.WriteLine("Anna nimesi, osoitteesi ja puhelinnumero");
            Console.WriteLine("Tässä antamasi tiedot: " + Console.ReadLine());
        }
    }
}
