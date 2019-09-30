using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    public class Task11
    {
        public string testavaKuvaus = ("");

        public void createFile()
        {
            Console.WriteLine("Anna haluamasi tiedoston nimi");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Anna jotain sisältöä tiedostoon");
            string inputText = Console.ReadLine();

            // Luodaan oikea tiedostopolku ja lisätään siihen tiedoston nimi
            string workDir = Environment.CurrentDirectory;
            string filu = Directory.GetParent(workDir).Parent.FullName + inputFile + ".txt";

            try
            {
                // Tarkista tiedoston olemassaolo     
                if (File.Exists(filu))
                {
                    File.Delete(filu);
                }

                // Luo uusi tiedosto ja dataa siihen  
                using (FileStream fs = File.Create(filu))
                {   
                    Byte[] contents = new UTF8Encoding(true).GetBytes(inputText);
                    fs.Write(contents, 0, contents.Length);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
