using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Events_2
{
    public class Rekening
    {
        public event EventHandler<NietOnderNulEventArgs> NietOnderNul;
        public int Saldo { get; set; }

        public Rekening(int saldo)
        {
            Saldo = saldo;
        }

        public void Overschrijving(int bedrag)
        {
            if (bedrag > Saldo)
            {
                NietOnderNul.Invoke(this, new NietOnderNulEventArgs($"Saldo ontoereikend , u hebt {bedrag - Saldo} te kort."));
            }
            else
            {
                Saldo -= bedrag;
            }
        }
    }
}
