using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Func_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Student, int> select;
            var studentenLijst = StudentData.Students;
            Console.Write("Kies een vak ( w , n , g ) :");
            var vak = Console.ReadLine().ToLower()[0];
            select = VakSelect(vak);

            Console.WriteLine("{0}", (Vak)vak);
            var max = studentenLijst.Max(select);
            Console.WriteLine("Hoogste score : {0}" , max);
            var min = studentenLijst.Min(select);
            Console.WriteLine("Laagste score : {0}" , min);
            var average = studentenLijst.Average(select);
            Console.WriteLine("Gemiddelde score : {0}" , average);

            Console.ReadLine();
        }


        public static Func<Student,int> VakSelect(char vak)
        {
            switch ((Vak)vak)
            {
                case Vak.Wiskunde:
                    return x => x.Wiskunde;
                case Vak.Nederlands:
                    return x => x.Nederlands;
                case Vak.Geschiedenis:
                    return x => x.Geschiendenis;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
