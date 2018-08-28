using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arrays
{
    class ExerciseOneSolution
    {
        static int[] testScores = new int[4]
        {
            20, 40, 60, 80
        };

        public static void totalOfScores()
        {
            int totalScores = 0;
            foreach (int score in testScores)
            {
                totalScores += score;
            }
            Console.WriteLine("The total score is:    " + totalScores);
            Console.ReadLine();
        }

        public static void averageOfScores()
        {
            double averageScores = 0;
            int totalScores = 0;
            foreach (int score in testScores)
            {
                totalScores += score;
            }
            averageScores = totalScores / testScores.Length;

            Console.WriteLine("The average score is:      " + testScores.Max());
            Console.ReadLine();
        }

        public static void maxOfScores()
        {
            Console.WriteLine("The Maximum score is:     " + testScores.Max());
            Console.ReadLine();
        }

        public static void minOfScores()
        {
            Console.WriteLine("The minimum score is:     " + testScores.Min());
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            totalOfScores();
            averageOfScores();
            maxOfScores();
            minOfScores();
        }
    }
}
