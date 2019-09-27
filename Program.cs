using System;

namespace CSharp_kurssin_tehtavat
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string selection = start();

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

                    case "15":
                        var Task15 = new Task15();
                        string textWall = Task15.getTextFile();
                        if (textWall == null)
                        {
                            break;
                        }
                        else
                        {
                            Task15.readTextFile(textWall);
                            break;
                        }

                    case "16":
                        var Task16 = new Task16();
                        Task16.inputTextToFile();
                        break;

                    case "17":
                        Console.WriteLine("Anna kaksi lukua potenssiin laskemista varten");
                        var Task17 = new Task17();
                        Console.WriteLine("Vastaus: " + Task17.poww());
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Tehtävää " + selection + " ei löydy");
                        break;
                }
            }
        }

        public static string start()
        {
            bool firstTime = true;
            if (!firstTime) Console.ReadKey();
            firstTime = false;
            Console.Clear();

            string title = @"
                    )          (             )  (                      )  (                 
   (     _ _     ( /(   (      )\ )       ( /(  )\ )  *   )         ( /(  )\ )       *   )  
   )\  _| | |_   )\())  )\    (()/(   (   )\())(()/(` )  /(    (    )\())(()/( (   ` )  /(  
 (((_)|_  .  _| ((_)\((((_)(   /(_))  )\ ((_)\  /(_))( )(_))   )\ |((_)\  /(_)))\   ( )(_)) 
 )\___|_     _|  _((_))\ _ )\ (_))   ((_)  ((_)(_)) (_(_()) _ ((_)|_ ((_)(_)) ((_) (_(_())  
((/ __| |_|_|   | || |(_)_\(_)| _ \ _ | | / _ \|_ _||_   _|| | | || |/ / / __|| __||_   _|  
 | (__          | __ | / _ \  |   /| || || (_) || |   | |  | |_| |  ' <  \__ \| _|   | |    
  \___|         |_||_|/_/ \_\ |_|_\ \__/  \___/|___|  |_|   \___/  _|\_\ |___/|___|  |_|    
                                                                                            
";
            Console.WriteLine(title);

            string start = "Syötä tehtävän numero tai poistu nollalla";
            Console.SetCursorPosition((Console.WindowWidth - start.Length) / 2, Console.CursorTop);
            Console.WriteLine(start);
            string selection = Console.ReadLine();
            Console.ResetColor();
            return selection;
        }
    }
}
