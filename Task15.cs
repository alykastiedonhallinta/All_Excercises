using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 15: Luo aliohjelma, joka lukee tiedoston ja palauttaa tiedoston sisältämän teks-tin pääohjelmaan, josta se sitten tulostetaan.
    public class Task15
    {
        public void createTextFile()
        {
            Console.WriteLine("Anna kauppalistalle nimi");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Anna kauppalistaan halutut asiat");
            string inputText = Console.ReadLine();

            string workDir = Environment.CurrentDirectory;
            string filu = Directory.GetParent(workDir).Parent.FullName + inputFile + ".txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(filu))
                {
                    File.Delete(filu);
                }

                // Create a new file     
                using (FileStream fs = File.Create(filu))
                {
                    // Add some text to file    
                    Byte[] contents = new UTF8Encoding(true).GetBytes(inputText);
                    fs.Write(contents, 0, contents.Length);
                }

                // Open the stream and read it back.    
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
        public void printTextFile()
        {

        }
    }

}
