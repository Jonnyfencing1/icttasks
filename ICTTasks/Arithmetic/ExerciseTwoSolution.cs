using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arithmetic
{
    class ExerciseTwoSolution
    {
        static void Main(string[] args)
        {
            double length, breadth, area, perimeter;

            length = 24.7;
            breadth = 25.9;
            area = length * breadth;
            perimeter = (length + breadth) * 2.0;

            Console.WriteLine("The Length of the rectangle is: " + length);
            Console.WriteLine("");
            Console.WriteLine("The breadth of the rectangle is: " + breadth);
            Console.WriteLine("");
            Console.WriteLine("The Area of rectangle is: " + area + "square centimetres");
            Console.WriteLine("");
            Console.WriteLine("The perimeter is rectangle is: " + perimeter + "centimeters");
            Console.ReadLine();
        }
    }
}
