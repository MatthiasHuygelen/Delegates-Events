using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Func_LINQ
{
    public class StudentData
    {
        public static List<Student> Students = new List<Student>
        {
            new Student
            {
                Naam = "Tim",
                Wiskunde = 10,
                Nederlands = 8,
                Geschiendenis = 7
            },
            new Student
            {
                Naam = "Tom",
                Wiskunde = 8,
                Nederlands = 7,
                Geschiendenis = 6
            },
            new Student
            {
                Naam = "Sandra",
                Wiskunde = 9,
                Nederlands = 9,
                Geschiendenis = 10
            },
            new Student
            {
                Naam = "Cedric",
                Wiskunde = 4,
                Nederlands = 5,
                Geschiendenis = 6
            },
            new Student
            {
                Naam = "Nicolas",
                Wiskunde = 8,
                Nederlands = 3,
                Geschiendenis = 7
            }
        };
    }
}
