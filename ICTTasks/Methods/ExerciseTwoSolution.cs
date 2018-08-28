using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Methods
{
    class ExerciseTwoSolution
    {
       static double getSquare(double numberPassedIn)
        {
            return numberPassedIn * numberPassedIn;
        }
        static double getCube(double numberPassedIn)
        {
            return Math.Pow(numberPassedIn, 3);
        }
        static double getReciprocal(double numberPassedIn)
        {
            return 1 / numberPassedIn;
        }
        static double getSquareRoot(double numberPassedIn)
        {
            return Math.Sqrt(numberPassedIn);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be squared: ");
            double numberToSquare = Double.Parse(Console.ReadLine());
            Console.WriteLine("The square of " + numberToSquare + " is: " + getSquare(numberToSquare));

            Console.WriteLine("Enter the number to be cubed: ");
            double numberToCube = Double.Parse(Console.ReadLine());
            Console.WriteLine("The cube of " + numberToCube + " is: " + getCube(numberToCube));

            Console.WriteLine("Enter the number to be inverse: ");
            double numberTOInverse = Double.Parse(Console.ReadLine());
            Console.WriteLine("The cube of " + numberTOInverse + " is: " + getReciprocal(numberTOInverse));

            Console.WriteLine("Enter the number to find the square root of: ");
            double numberToSquareRoot = Double.Parse(Console.ReadLine());
            Console.WriteLine("The square root of " + numberToSquareRoot + " is: " + getSquareRoot(numberToSquareRoot));
            Console.ReadLine();
        }
    }
}
