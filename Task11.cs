﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CSharp_kurssin_tehtavat
{
    //Tehtävä 11: Luo ohjelma, joka kysyy käyttäjältä tiedoston nimen.Ohjelma tarkistaa löytyykö tiedostoa, ellei tiedostoa löydy, ohjelma luo sen nimisen tiedoston.Seuraavaksi käyttäjältä kysytään tekstiä, mitä hän haluaisi tallentaa ohjelmaan, ohjelma tallentaa annetun tekstin tiedostoon ja sulkee sen.
    public class Task11
    {
        public void createFile()
        {
            Console.WriteLine("Anna haluamasi tiedoston nimi");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Anna jotain sisältöä tiedostoon");
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
