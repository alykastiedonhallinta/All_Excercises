using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 7: Luo ohjelma, joka kysyy käyttäjältä hänen nimensä.Ohjelma tulostaa tervehdyk-sen käyttäjälle, johon tulostaa myös käyttäjän antaman nimen.
    public class Task7
    {
        public void askName()
        {
            Console.WriteLine("Anna nimesi");
            string yourName = Console.ReadLine();
            Console.WriteLine("Moi " + yourName);
        }
    }
}
