using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, total = 0;

            if (int.TryParse(Console.ReadLine(), out input))
                for (int i = 1; i <= input; i++)
                    total += i % 2 == 0 ? i : 0; //if remainder of i / 2 = 0 (even number), add i to total, else add 0
            
            Console.WriteLine(total);


            Console.ReadLine();
        }
    }
}
