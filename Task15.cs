using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 15: Luo aliohjelma, joka lukee tiedoston ja palauttaa tiedoston sisältämän teks-tin pääohjelmaan, josta se sitten tulostetaan.
    public class Task15
    {
        public string getTextFile()
        {
            Console.WriteLine("Anna .txt -tiedoston nimi (winkwink: test)");
            string inputFile = Console.ReadLine();

            string workDir = Environment.CurrentDirectory;
            string filu = Directory.GetParent(workDir).Parent.FullName + "\\" + inputFile + ".txt";

            try
            {
                // Check if file already exists.      
                if (File.Exists(filu))
                {
                    return filu;    
                }
                else
                {
                    Console.WriteLine("Tiedostoa: " + filu + " ei löytynyt.");
                    return null;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public void readTextFile(string filu)
        {
            // Open the stream and read it back. 
            using (StreamReader sr = File.OpenText(filu))
            {
                Console.WriteLine("Tekstitiedoston sisältö on: ");
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }

}
