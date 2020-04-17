using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Delegates_3
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

        delegate int Calculate(int a, int b);
        public static void CalculateResults(int a , int b)
        {
            Calculate methode = delegate (int getal1, int getal2) { return getal1 + getal2; };
            Console.WriteLine("{0} + {1} = {2}" , a , b , methode(a, b));

            methode = delegate (int getal1, int getal2) { return getal1 - getal2; };
            Console.WriteLine("{0} - {1} = {2}", a, b, methode(a, b));

            methode = delegate (int getal1, int getal2) { return getal1 * getal2; };
            Console.WriteLine("{0} * {1} = {2}", a, b, methode(a, b));
        }
    }
}
