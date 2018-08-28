using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arrays
{
    class ExerciseTwo_Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days' temperatures? ");

            int days = Int32.Parse(Console.ReadLine());

            int[] temperatures = new int[days];
            
            for(int counter = 0; counter < temperatures.Length; counter++)
            {
                Console.WriteLine("Day " + counter + "s high temp: ");
                temperatures[counter] = Int32.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int counter = 0; counter < temperatures.Length; counter++)
            {
                sum += temperatures[counter];
            }
            double average = (double)sum / temperatures.Length;
            Console.WriteLine("Average temp = " + average);

            int count = 0;

            for(int counter = 0; counter < temperatures.Length; counter++)
            {
                if(temperatures[counter] > average)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " days were above average");
            Console.ReadLine();
        }
    }
}
