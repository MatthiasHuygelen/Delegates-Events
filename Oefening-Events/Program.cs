using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Tankwagen wagen = new Tankwagen(200, 5000);
            wagen.LooptOver += Wagen_LooptOver;

            while (wagen.Inhoud != wagen.MaxInhoud)
            {
                Console.WriteLine("Hoeveel wenst u te tanken");
                wagen.Tanken(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Inhoud : {0}", wagen.Inhoud);
                Console.WriteLine("Maximum inhoud : {0}", wagen.MaxInhoud);
            }
            Console.ReadLine();
        }

        private static void Wagen_LooptOver(object sender, LooptOverEventArgs e)
        {
            Console.WriteLine("{0} , Er kon nog {1} bij.", e.Melding, e.GetankteHoeveelheid);
        }
    }
}
