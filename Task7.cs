using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task7
    {
        public string testavaKuvaus = ("Tehtävä 7: Luo ohjelma, joka kysyy käyttäjältä hänen nimensä.Ohjelma tulostaa tervehdyk-sen käyttäjälle, johon tulostaa myös käyttäjän antaman nimen.");

        public void askName()
        {
            // Otetaan stringi vastaan ja tulostetaan se
            Console.WriteLine("Anna nimesi");
            string yourName = Console.ReadLine();
            Console.WriteLine("Moi " + yourName);
        }
    }
}
