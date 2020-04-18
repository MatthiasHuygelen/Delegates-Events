using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Events_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening = new Rekening(100);
            rekening.NietOnderNul += Rekening_NietOnderNul;

            while (rekening.Saldo > 0)
            {
                Console.WriteLine("Geef het bedrag dat u wilt overschrijven");
                rekening.Overschrijving(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(" --- Nieuw Saldo : {0} ---", rekening.Saldo);
            }

            rekening.NietOnderNul -= Rekening_NietOnderNul;
            Console.ReadLine();
        }

        private static void Rekening_NietOnderNul(object sender, EventArgs e)
        {
            Console.WriteLine("Saldo ontoereikend");
        }
    }
}
