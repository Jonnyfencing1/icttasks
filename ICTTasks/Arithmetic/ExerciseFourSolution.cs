using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arithmetic
{
    class ExerciseFourSolution
    {
        static void Main(string[] args)
        {
            double hours, ratePerHour, gross, deductions, deductionspercentage, nett;
            deductionspercentage = 0.20;

            Console.WriteLine("How many hours were worked?");
            hours = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the rate paid per hour? ");
            ratePerHour = double.Parse(Console.ReadLine());

            gross = hours * ratePerHour;

            deductions = gross * deductionspercentage;

            nett = gross - deductions;

            Console.WriteLine("Hours:  " + hours);
            Console.WriteLine("");
            Console.WriteLine("Rate:    £" + ratePerHour);
            Console.WriteLine("");
            Console.WriteLine("Deductions: £" + deductions);
            Console.WriteLine("");
            Console.WriteLine("Nett:    £" + nett);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
