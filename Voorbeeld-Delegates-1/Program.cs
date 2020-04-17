using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Delegate_1
{
    class Program
    {
        public delegate void MyFirstDelegate();

        static void Main(string[] args)
        {
            MyFirstDelegate fd1 = Fun1;
            MyFirstDelegate fd2 = Fun2;
            MyFirstDelegate fd3 = Fun3;
            //MyFirstDelegate fd4 = fd1 + fd2 + fd3;

            fd1();
            fd2();
            fd3();
            //fd4();

            Console.ReadKey();
        }
        public static void Fun1()
        {
            Console.WriteLine("Functie 1");
        }
        public static void Fun2()
        {
            Console.WriteLine("Functie 2");
        }
        public static void Fun3()
        {
            Console.WriteLine("Functie 3");
        }
    }
}
