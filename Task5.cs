﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task5
    {
        string caps = "AAAAPUVA";

        public string testavaKuvaus = ("Tehtävä 5: Luo merkkijono, jonka arvoksi asetat ”ISOTKIRJAIMET”. Muuta kirjaimet pieniksi kirjaimiksi ja käännä kirjainten järjestys.Tulosta vastaus.");

        // Luodaan aliohjelma 
        public void capsOff()
        {
            // Luodaan kirjaintaulukko, joka muutetaan samantien pieniksi kirjaimiksi
            char[] lowereversed = caps.ToLower().ToCharArray();

            // käydään uusi merkkijono loopissa läpi takaperin ja printataan kirjain kerrallaan ulos
            for (int i = lowereversed.Length - 1; i >= 0; i--)
            {
                Console.Write(lowereversed[i]);
            }
        }
    }
}
