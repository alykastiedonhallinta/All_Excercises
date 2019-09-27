using System;

namespace CSharp_kurssin_tehtavat
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Syötä tehtävän numero");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        var Task1 = new Task1();
                        Task1.Calculate();
                        break;

                    case "2":
                        var Task2 = new Task2();
                        Task2.Calculate();
                        break;

                    case "3":
                        var Task3 = new Task3();
                        Task3.Calculate();
                        break;








                }
                
                
            }
        }
    }
}
