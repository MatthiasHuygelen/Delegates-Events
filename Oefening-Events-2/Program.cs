using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oefening_Events_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de countdown tijd in ( HH:mm:ss ) : ");
            string timeInput = Console.ReadLine();
            var timeList = timeInput.Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            Timer timer = new Timer(timeList[0], timeList[1], timeList[2]);
            timer.CountdownEndedEvent += Timer_ItsTime;
            timer.CurrentTimeEvent += Timer_CurrentTime;
            timer.Start();
        }

        private static void Timer_CurrentTime(object sender, string e)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition((Console.WindowWidth - e.Length) / 2, Console.WindowHeight /2);
            Console.WriteLine(e);
        }

        private static void Timer_ItsTime(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.BackgroundColor = Console.BackgroundColor == ConsoleColor.White ? ConsoleColor.Black : ConsoleColor.White;
                Thread.Sleep(100);
            }
        }
    }
}
