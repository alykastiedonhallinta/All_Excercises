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
                        Task3.Combine();
                        break;

                    case "11":
                        var Task11 = new Task11();
                        Task11.createFile();
                        break;

                    case "13":
                        var Task13 = new Task13();
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Task13.twoNumbers(a, b));
                        break;

                    case "14":
                        var Task14 = new Task14();
                        int c = Convert.ToInt32(Console.ReadLine());
                        double juuri = Task14.Nelio(c);
                        Task14.Tulosta(juuri);
                        break;







                }
                
                
            }
        }
    }
}
