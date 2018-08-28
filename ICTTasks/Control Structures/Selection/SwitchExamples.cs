using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks
{
    class SwitchExamples
    {
        static void Main(string[] args)
        {
            char inputerLetter;
            Console.WriteLine("Enter a letter");
            inputerLetter = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(inputerLetter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
