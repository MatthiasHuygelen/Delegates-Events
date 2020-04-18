using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Events_2
{
    public class NietOnderNulEventArgs : EventArgs
    {
        public string Melding { get; set; }

        public NietOnderNulEventArgs(string melding)
        {
            Melding = melding;
        }
    }
}
