using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task10
    {
        public string testavaKuvaus = ("//Tehtävä 10: Luo ohjelma, joka tarkistaa onko sana palindromi.Palindromi on sana, joka on samanlainen etu- ja takaperin. Esimerkkisanana on ”saippuakauppias”. Ohjelma kysyy käyt-täjältä sanaa ja tulostaa annetun sanan ja tiedon onko sana palindromi.");
        
        public void Palindromi()
        {
            // Kysellään palindromia ja laitetaan se kirjaintaulukkoon. 
            Console.WriteLine("Anna sana joka on mahdollisesti palindromi");
            char[] palindromiko = Console.ReadLine().ToCharArray();
            string okimordnilap = "";
            // Käydään kirjaintaulukko läpi toisinpäin ja tulostellaan se samalla.
            for (int i = palindromiko.Length - 1; i >= 0; i--)
            {
                okimordnilap += palindromiko[i];
            }

            // Vertaillaan sanoja keskenään
            string palindromi = new string(palindromiko);
            if (okimordnilap == palindromi)
            {
                Console.WriteLine("Kyllä. " + palindromi + " on palindromi!");
            }
            else
            {
                Console.WriteLine(palindromi + " ei kyllä ole palindromi.");
            }
        }
    }
}
