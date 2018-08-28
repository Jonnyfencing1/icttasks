using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Control_Structures
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            char op;
            double first, second, result;

            Console.Write("Enter First Number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;
                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;
                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
