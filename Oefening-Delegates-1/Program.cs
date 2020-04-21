using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Delegates_1
{
    class Program
    {
        #region FUNC
        static void Main(string[] args)
        {
            Console.Write("Geef het 1e getal : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het 2e getal : ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----");

            Console.WriteLine("1) Optellen");
            Console.WriteLine("2) Aftrekken");
            Console.WriteLine("3) Vermenigvuldigen");
            Console.WriteLine("4) Delen");
            Console.Write("Kies een berekening : ");
            int type = Convert.ToInt32(Console.ReadLine());
            Func<double, double, double> methode = GetCalculationMethode(type);

            Console.WriteLine("Oplossing : {0} ", methode(a, b));
            Console.ReadLine();
        }
        public static Func<double, double, double> GetCalculationMethode(int type)
        {
            switch (type)
            {
                case (int)CalculationType.Add:
                    return (a, b) => a + b;
                case (int)CalculationType.Substract:
                    return (a, b) => a - b;
                case (int)CalculationType.Multiply:
                    return (a, b) => a * b;
                case (int)CalculationType.Divide:
                    return (a, b) => a / b;
                default:
                    throw new NotSupportedException();
            }
        }
        #endregion

        #region delegates
        //public delegate double CalculationMethode(double a, double b);

        //static void Main(string[] args)
        //{
        //    Console.Write("Geef het 1e getal : ");
        //    double a = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Geef het 2e getal : ");
        //    double b = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("-----");

        //    Console.WriteLine("1) Optellen");
        //    Console.WriteLine("2) Aftrekken");
        //    Console.WriteLine("3) Vermenigvuldigen");
        //    Console.WriteLine("4) Delen");
        //    Console.Write("Kies een berekening : ");
        //    int type = Convert.ToInt32(Console.ReadLine());
        //    CalculationMethode methode = GetCalculationMethode(type);

        //    Console.WriteLine("Oplossing : {0} ", methode(a, b));
        //    Console.ReadLine();
        //}
        //public static CalculationMethode GetCalculationMethode(int type)
        //{
        //    switch (type)
        //    {
        //        case (int)CalculationType.Add:
        //            return Calculation.Add;
        //        case (int)CalculationType.Substract:
        //            return Calculation.Substract;
        //        case (int)CalculationType.Multiply:
        //            return Calculation.Multiply;
        //        case (int)CalculationType.Divide:
        //            return Calculation.Divide;
        //        default:
        //            throw new NotSupportedException();
        //    }

        //    // INLINE
        //    //switch (type)
        //    //{
        //    //    case (int)CalculationType.Add:
        //    //        return delegate (double a, double b) { return a + b; };
        //    //    case (int)CalculationType.Substract:
        //    //        return delegate (double a, double b) { return a - b; };
        //    //    case (int)CalculationType.Multiply:
        //    //        return delegate (double a, double b) { return a * b; };
        //    //    case (int)CalculationType.Divide:
        //    //        return delegate (double a, double b) { return a / b; };
        //    //    default:
        //    //        throw new NotSupportedException();
        //    //}
        //}

        #endregion
    }
}
