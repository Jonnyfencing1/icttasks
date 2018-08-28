using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Methods
{
    class ExerciseOneSolution
    {
        static double length, breadth, height, volume, surfacearea;


        static void readDimensions()
        {
            Console.WriteLine("Enter the Length: ");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height: ");
            Console.ReadLine();
        }

        static double getVolume()
        {
            return length * breadth * height;
        }

        static double getSurfaceArea()
        {
            return ((2 * length * breadth) + (2 * length * height) + (2 * height * breadth));
        }
        static void displayDimensions()
        {
            Console.WriteLine("Length = \t\t" + length);
            Console.WriteLine("Breadth = \t\t" + breadth);
            Console.WriteLine("Height = \t\t" + height);
        }

        static void Main(string[] args)
        {
            readDimensions();
            volume = getVolume();
            surfacearea = getSurfaceArea();
            displayDimensions();
            Console.WriteLine("Volume = \t\t" + volume);
            Console.WriteLine("Surface Area = \t\t" + surfacearea);
            Console.ReadLine();
        }
    }
}
