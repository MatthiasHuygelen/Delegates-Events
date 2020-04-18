using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Events
{
    public class Tankwagen
    {
        public event EventHandler<LooptOverEventArgs> LooptOver;
        public int Inhoud { get; set; }
        public int MaxInhoud { get; set; }
        public Tankwagen(int inhoud , int maxInhoud)
        {
            Inhoud = inhoud;
            MaxInhoud = maxInhoud;
        }

        public void Tanken(int teTankenHoeveelheid)
        { 
            if (MaxInhoud < (Inhoud + teTankenHoeveelheid))
            {
                LooptOver.Invoke(this, new LooptOverEventArgs("TankWagen zit vol", MaxInhoud - Inhoud));
                Inhoud = MaxInhoud;
            }
            else
            {
                Inhoud += teTankenHoeveelheid;
            }
        }
    }
}
