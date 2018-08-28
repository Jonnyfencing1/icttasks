using System;

namespace ICTTasks
{
    class grades
    {
        static void Main(string[] args)
        {
            string grade;
            Console.Write("Enter Student Grade: ");

            grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent!\n");
                    break;
                case "B":
                case "C":
                    Console.WriteLine("Well Done\n");
                    break;
                case "D":
                    Console.WriteLine("You passed\n");
                    break;
                case "F":
                    Console.WriteLine("Better try again\n");
                    break;
                default:
                    Console.WriteLine("Your Grade is Invalid\n");
                    break;
            }
            Console.WriteLine("Your Grade is {0}", grade);
            Console.ReadKey();
        }
    }
}
