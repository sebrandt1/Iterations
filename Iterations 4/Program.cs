using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Iterations_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                int timer = ((int)stopwatch.ElapsedMilliseconds / 1000) - input;

                while (timer < 0)
                {
                    timer = ((int)stopwatch.ElapsedMilliseconds / 1000) - input;
                    string timerMsg = timer.ToString().Replace("-", string.Empty);
                    Console.Clear();
                    Console.WriteLine(timerMsg);
                }
                Console.WriteLine("Takeoff!");
            }

            Console.ReadKey();
        }
    }
}
