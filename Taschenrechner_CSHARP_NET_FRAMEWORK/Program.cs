using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_CSHARP_NET_FRAMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Calculator
            

            Console.WriteLine("Gib die erste Zahl an");
            double ersteZahl = Convert.ToInt32(Console.ReadLine());

            /* if (ersteZahl == char)
            {

            } */

            Console.WriteLine("Gib die zweite Zahl an");
            double zweiteZahl = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Wähdle den Operator");
                    Console.WriteLine("d = dividieren");
                    Console.WriteLine("a = addieren");
                    Console.WriteLine("s = subtrahieren");
                    Console.WriteLine("m = multiplizieren");

            // Switch statement to calculate
            switch (Console.ReadLine())
            {
                case "d":
                    Console.Clear();
                    Console.WriteLine($"Rechnung: {ersteZahl} / {zweiteZahl}");
                    Console.WriteLine(ersteZahl / zweiteZahl);
                    break;

                case "a":
                    Console.Clear();
                    Console.WriteLine($"Rechnung: {ersteZahl} + {zweiteZahl}");
                    Console.WriteLine(ersteZahl + zweiteZahl);
                    break;

                case "s":
                    Console.Clear();
                    Console.WriteLine($"Rechnung: {ersteZahl} - {zweiteZahl}");
                    Console.WriteLine(ersteZahl - zweiteZahl);
                    break;


                case "m":
                    Console.Clear();
                    Console.WriteLine($"Rechnung: {ersteZahl} * {zweiteZahl}");
                    Console.WriteLine(ersteZahl * zweiteZahl);
                    break;
            }




            // Other method to calculate using if statements
            /* string op = Console.ReadLine();

                if (op == "d")
                {
                    Console.WriteLine(ersteZahl / zweiteZahl);
                }

                if (op == "a")
                {
                    Console.WriteLine(ersteZahl + zweiteZahl);
                }

                if (op == "s")
                {
                    Console.WriteLine(ersteZahl - zweiteZahl);
                }

                if (op == "m")
                {
                    Console.WriteLine(ersteZahl * zweiteZahl);
                } */
            Console.WriteLine();
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();


        }
    }
}
