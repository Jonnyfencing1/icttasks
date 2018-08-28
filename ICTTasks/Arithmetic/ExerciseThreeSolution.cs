using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arithmetic
{
    class ExerciseThreeSolution
    {
        static void Main(string[] args)
        {
            int testOneMark, testTwoMark, totalMark;
            double averageMark;

            testOneMark = 65;
            testTwoMark = 60;

            totalMark = testOneMark + testTwoMark;

            averageMark = totalMark / 2.0;
            Console.WriteLine("The Total Mark is: " + totalMark);
            Console.WriteLine("");
            Console.WriteLine("The average mark is: " + averageMark);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
