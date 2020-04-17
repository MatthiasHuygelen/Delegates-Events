using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Delegates_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het 1e getal : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het 2e getal : ");
            double b = Convert.ToInt32(Console.ReadLine());
            CalculateResults(a, b);
            Console.ReadLine();
        }

        delegate double Calculate(double a, double b);
        public static void CalculateResults(double a, double b)
        {
            Calculate methode = Calculation.Add;
            Console.WriteLine("{0} + {1} = {2}", a, b, methode(a, b));

            methode = Calculation.Substract;
            Console.WriteLine("{0} - {1} = {2}", a, b, methode(a, b));

            methode = Calculation.Multiply;
            Console.WriteLine("{0} * {1} = {2}", a, b, methode(a, b));
        }
     
    }

   
}
