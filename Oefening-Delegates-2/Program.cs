using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Delegates_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke data wenst u te zien?");
            Console.WriteLine("1. School");
            Console.WriteLine("2. Niveau");
            Console.WriteLine("3. School en Niveau");
            var group = Convert.ToInt32(Console.ReadLine());
            Func<Student, object> grouping = CreateGrouping(group);
            var studentGroups = StudentData.Students.OrderBy(grouping).GroupBy(grouping);

            Console.WriteLine("-------------DATA-------------");
            foreach (var item in studentGroups)
            {
                Console.WriteLine("{0} : {1}", (Groupings)group, item.Key);
                Console.WriteLine("Hoogste : {0}", item.ToList().Max(x => x.Score));
                Console.WriteLine("Laagste : {0}", item.ToList().Min(x => x.Score));
                Console.WriteLine("Gemiddelde : {0}", Math.Round(item.ToList().Average(x => x.Score), 2));
                Console.WriteLine("-------"); 
            }
            Console.ReadLine();
        }

        public static Func<Student, object> CreateGrouping(int group)
        {
            switch ((Groupings)group)
            {
                case Groupings.School:
                    return x => x.School;
                case Groupings.Niveau:
                    return x => x.Niveau;
                case Groupings.Gecombineerd:
                    return x => (x.School, x.Niveau);
                default:
                    throw new NotSupportedException();
            }
        }
    }

    public enum Groupings
    {
        School = 1 ,
        Niveau = 2 ,
        Gecombineerd = 3
    }

}
