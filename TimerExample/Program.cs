using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += MyTimer_Elapsed;      
            myTimer.Start();

            Timer myTimer1 = new Timer(1000);
            myTimer1.Elapsed += MyTimer_Elapsed1;
            myTimer1.Start();

            Console.WriteLine("Press Entre to remove the yellow event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}" ,e.SignalTime);
        }
    }
}
