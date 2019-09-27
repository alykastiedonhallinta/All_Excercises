using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    // Tehtävä 17: Luo aliohjelma, joka hoitaa potenssilaskutoimituksen käyttäjän antamilla arvoilla.Käyttäjältä kysytään luku ja mihin potenssiin luku halutaan.Aliohjelma ottaa vastaan luvun ja potenssin.Vastaus tulostetaan pääohjelmasta.
    public class Task17
    {
        public float a = float.Parse(Console.ReadLine());
        public float b = float.Parse(Console.ReadLine());
        public float poww()
        {
            return MathF.Pow(a, b);
        }
    }
}
