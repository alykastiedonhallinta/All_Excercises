using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task8
    {
        public string testavaKuvaus = ("Tehtävä 8: Luo ohjelma, joka kysyy käyttäjältä kaksi numeroa ja laskee ne yhteen.Ohjelma sitten tulostaa annetut luvun ja vastauksen.");

        public void Calculate()
        {
            string a, b;

            a = Console.ReadLine();
            b = Console.ReadLine();

            // Yritetään muuttaa kysytyt arvot kokonaisluvuiksi, muuten heittää herjan
            try
            {
                Console.WriteLine("Summa on " + (Convert.ToInt32(a) + Convert.ToInt32(b)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Nyt meni jotain vikaan. " + e);
            }
        }
    }
}
