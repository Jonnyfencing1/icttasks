using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Control_Structures.Iterations
{
    class Sum
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter a number : ");
            num = int.Parse(Console.ReadLine());
            while(num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);

            Console.ReadKey();
        }
        
    }
}
