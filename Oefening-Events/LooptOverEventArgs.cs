using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Events
{
    public class LooptOverEventArgs : EventArgs
    {
        public string Melding { get; set; }
        public int GetankteHoeveelheid { get; set; }
        public LooptOverEventArgs(string melding , int getankeHoeveelheid)
        {
            Melding = melding;
            GetankteHoeveelheid = getankeHoeveelheid;
        }
    }
}
