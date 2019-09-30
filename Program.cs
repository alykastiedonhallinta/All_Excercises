using System;
using System.IO;

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
                        global::System.Console.WriteLine(Task1.testavaKuvaus);
                        Task1.Calculate();
                        break;

                    case "2":
                        var Task2 = new Task2();
                        global::System.Console.WriteLine(Task2.testavaKuvaus);
                        Task2.Calculate();
                        break;

                    case "3":
                        var Task3 = new Task3();
                        global::System.Console.WriteLine(Task3.testavaKuvaus);
                        Task3.Combine();
                        break;

                    case "4":
                        var Task4 = new Task4();
                        global::System.Console.WriteLine(Task4.testavaKuvaus);
                        Task4.Combine();
                        break;

                    case "5":
                        var Task5 = new Task5();
                        global::System.Console.WriteLine(Task5.testavaKuvaus);
                        Task5.capsOff();
                        break;

                    case "6":
                        var Task6 = new Task6();
                        global::System.Console.WriteLine(Task6.testavaKuvaus);
                        Task6.replaceThings();
                        break;

                    case "7":
                        var Task7 = new Task7();
                        global::System.Console.WriteLine(Task7.testavaKuvaus);
                        Task7.askName();
                        break;

                    case "8":
                        var Task8 = new Task8();
                        global::System.Console.WriteLine(Task8.testavaKuvaus);
                        Task8.Calculate();
                        break;

                    case "9":
                        var Task9 = new Task9();
                        global::System.Console.WriteLine(Task9.testavaKuvaus);
                        Task9.askInfo();
                        break;

                    case "10":
                        var Task10 = new Task10();
                        global::System.Console.WriteLine(Task10.testavaKuvaus);
                        Task10.Palindromi();
                        break;

                    case "11":
                        var Task11 = new Task11();
                        global::System.Console.WriteLine(Task11.testavaKuvaus);
                        Task11.createFile();
                        break;

                    case "12":
                        var Task12 = new Task12();
                        global::System.Console.WriteLine(Task12.testavaKuvaus);
                        Task12.createGroceryList();
                        break;

                    case "13":
                        var Task13 = new Task13();
                        global::System.Console.WriteLine(Task13.testavaKuvaus);
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Task13.twoNumbers(a, b));
                        break;

                    case "14":
                        var Task14 = new Task14();
                        global::System.Console.WriteLine(Task14.testavaKuvaus);
                        int c = Convert.ToInt32(Console.ReadLine());
                        double juuri = Task14.Nelio(c);
                        Task14.Tulosta(juuri);
                        break;

                    case "15":
                        var Task15 = new Task15();
                        global::System.Console.WriteLine(Task15.testavaKuvaus);
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
                        global::System.Console.WriteLine(Task16.testavaKuvaus);
                        Task16.inputTextToFile();
                        break;

                    case "17":
                        Console.WriteLine("Anna kaksi lukua potenssiin laskemista varten");
                        var Task17 = new Task17();
                        global::System.Console.WriteLine(Task17.testavaKuvaus);
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
            //Console.Clear();

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
            //Console.SetCursorPosition((Console.WindowWidth - start.Length) / 2, Console.CursorTop);
            Console.WriteLine(start);
            string selection = Console.ReadLine();
            Console.ResetColor();
            return selection;
        }
    }
}
