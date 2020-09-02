using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, result = 1;

            if(int.TryParse(Console.ReadLine(), out input))
            {
                for(int i = 0; i < input; i++)
                {
                    result = result * (i + 1);
                }
            }

            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
