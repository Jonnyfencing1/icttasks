using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Arithmetic
{
    class ExerciseOneSolution
    {
        static void Main(string[] args)
        {
            int length, breadth, area, perimeter;

            length = 24;
            breadth = 25;
            area = length * breadth;
            perimeter = (length + breadth) + 2;

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
