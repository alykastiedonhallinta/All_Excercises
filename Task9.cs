using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task9
    {
        public string testavaKuvaus = ("Tehtävä 9: Luo ohjelma, joka kysyy käyttäjältä nimen, osoitteen ja puhelinnumeron.Tulosta käyttäjän syöttämät tiedot.");

        public void askInfo()
        {
            // Kysellään ja tulostellaan tiedot
            Console.WriteLine("Anna nimesi, osoitteesi ja puhelinnumero");
            Console.WriteLine("Tässä antamasi tiedot: " + Console.ReadLine());
        }
    }
}
