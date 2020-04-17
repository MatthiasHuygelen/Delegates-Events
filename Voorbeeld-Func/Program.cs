using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het 1e getal : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het 2e getal : ");
            int b = Convert.ToInt32(Console.ReadLine());
            CalculateResults(a, b);
            Console.ReadLine();
        }

        public static void CalculateResults(int a, int b)
        {
            Func<int, int, int> methode;
            methode = (getal1, getal2) => getal1 + getal2;
            Console.WriteLine("{0} + {1} = {2}", a, b, methode(a, b));

            methode = (getal1, getal2) => getal1 - getal2;
            Console.WriteLine("{0} - {1} = {2}", a, b, methode(a, b));

            methode = (getal1, getal2) => getal1 * getal2;
            Console.WriteLine("{0} * {1} = {2}", a, b, methode(a, b));
        }

    }
}
