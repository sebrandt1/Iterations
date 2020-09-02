using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 2 values with a space between each value: ");
            
            //Using a list so we can use list.Min() and list.Max() to determine which is the highest and which is the lowest value
            List<int> result = new List<int>();

            //user input, split by space and convert it to list, foreach iterate and add each value to result list
            Console.ReadLine().Split(' ').ToList().ForEach(x => result.Add(int.Parse(x))); //assuming user only inputs numbers (no error handling)

            for (int i = result.Min(); i < result.Max() + 1; i++)
                Console.WriteLine(i);


            Console.ReadKey();
        }
    }
}
