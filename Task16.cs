using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    
    public class Task16
    {
        public string testavaKuvaus = ("Tehtävä 16: Luo aliohjelma, joka ottaa vastaan merkkijonon ja tallentaa merkkijonon tekstitiedostoon.");

        public void inputTextToFile()
        {
            Console.WriteLine("Anna merkkijono");
            string inputText = Console.ReadLine();

            string workDir = Environment.CurrentDirectory;
            string filu = Directory.GetParent(workDir).Parent.FullName + "\\inputFile.txt";

            try
            {     
                if (File.Exists(filu))
                {
                    // Poistetaan vanha jos se on jo olemassa
                    File.Delete(filu);
                    Console.WriteLine("Aikaisempi tiedosto on korvattu nyt uudella.");
                }
                using (FileStream fs = File.Create(filu))
                {   
                    // Kirjoitellaan ja printtaillaan tiedoston nimi
                    Byte[] contents = new UTF8Encoding(true).GetBytes(inputText);
                    fs.Write(contents, 0, contents.Length);
                    Console.WriteLine("Tekstisi on tallennettu tiedostoon: " + filu);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
