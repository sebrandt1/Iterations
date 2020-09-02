using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dice = new List<int>();
            dice.AddRange(Enumerable.Range(1, 6));

            dice.ForEach(x => dice.ForEach(y => Console.WriteLine($"({x},{y})")));

            Console.ReadKey();
        }
    }
}
