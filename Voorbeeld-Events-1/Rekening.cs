using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Events_1
{
    public class Rekening
    {
        public event EventHandler NietOnderNul;
        public int Saldo { get; set; }

        public Rekening(int saldo)
        {
            Saldo = saldo;
        }

        public void Overschrijving(int bedrag)
        {
            if (bedrag > Saldo)
            {
                NietOnderNul.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Saldo -= bedrag;
            }
        }
    }
}
