﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            if(int.TryParse(Console.ReadLine(), out input))
            {
                for(int i = 1; i <= input; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else
                        Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
