using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task12
    {
        public string testavaKuvaus = ("Tehtävä 12: Luo tekstitiedosto, johon kirjoitat ostoslistasi. Tämän jälkeen luo ohjelma, joka lukee kyseisen tiedoston ja tulostaa ostoslistasi");

        public void createGroceryList()
        {
            Console.WriteLine("Anna kauppalistalle nimi");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Anna kauppalistaan halutut asiat");
            string inputText = Console.ReadLine();

            string workDir = Environment.CurrentDirectory;
            string filu = Directory.GetParent(workDir).Parent.FullName + inputFile + ".txt";

            try
            {     
                if (File.Exists(filu))
                {
                    File.Delete(filu);
                }
  
                using (FileStream fs = File.Create(filu))
                { 
                    Byte[] contents = new UTF8Encoding(true).GetBytes(inputText);
                    fs.Write(contents, 0, contents.Length);
                }

                // Luetaan tiedostoa ja tulostellaan se pihalle    
                using (StreamReader sr = File.OpenText(filu))
                {
                    Console.WriteLine("Kauppalistan sisältö on: ");
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
