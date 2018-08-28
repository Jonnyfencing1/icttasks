using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Control_Structures.Iterations
{
    class Average
    {
        static void Main(string[] args)
        {
            double inputValue;
            double max, min, avg, sum;
            min = double.MaxValue;
            int noOfValue = 10;
            max = avg = sum = 0;

            for (int nextValue = 0; nextValue < noOfValue; nextValue++)
            {
                Console.Write("Enter your value ");
                inputValue = double.Parse(Console.ReadLine());

                sum += inputValue;

                if(inputValue > max)
                {
                    max = inputValue;
                }
                if(inputValue < min)
                {
                    min = inputValue;
                }
            }
            avg = sum / noOfValue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nThe Average of the values is {0.0.0}", avg);
            Console.WriteLine("\nThe maximum of the values is {0.0.0}", max);
            Console.WriteLine("\nThe minimum of the values is {0.0.0}", min);

            Console.ResetColor();
            Console.WriteLine("\nProgram Ended...");
        }
    }
}
