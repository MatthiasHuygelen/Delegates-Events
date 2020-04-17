using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Func_Action
{
    class Program
    {
        static Action<string, ConsoleColor> print = (text, consoleColor) =>
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        };

        static void Main(string[] args)
        { 
            Console.Write("Geef het 1e getal : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het 2e getal : ");
            int b = Convert.ToInt32(Console.ReadLine());
            CalculateResults(a, b , print);
            Console.ReadLine();
        }

        public static void CalculateResults(int a, int b, Action<string, ConsoleColor> printResultFunction)
        {
            Func<int, int, int> methode;
            methode = (getal1, getal2) => getal1 + getal2; ;
            printResultFunction($"{a} + {b} = {methode(a, b)}", ConsoleColor.Red);

            methode = (getal1, getal2) => getal1 - getal2;
            printResultFunction($"{a} - {b} = {methode(a, b)}", ConsoleColor.Green);

            methode = (getal1, getal2) => getal1 * getal2;
            printResultFunction($"{a} * {b} = {methode(a, b)}", ConsoleColor.Blue);
        }
    }
}
