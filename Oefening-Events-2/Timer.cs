using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oefening_Events_2
{
    public class Timer
    {
        public event EventHandler CountdownEndedEvent;
        public event EventHandler<string> CurrentTimeEvent;
        public TimeSpan TimeSpan { get; set; }
        public Timer(int houres , int minutes , int seconds)
        {
            TimeSpan = new TimeSpan(houres, minutes, seconds);
        }
        public void Start()
        {
            while (TimeSpan.TotalSeconds > 0)
            {
                Thread.Sleep(1000);
                TimeSpan = TimeSpan.Add(new TimeSpan(0, 0, -1));
                CurrentTimeEvent?.Invoke(this, TimeSpan.ToString());
            }
            CountdownEndedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
