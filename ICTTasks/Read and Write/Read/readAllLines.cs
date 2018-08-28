using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Read
{
    class readAllLines
    {
        public static void ReadAllLines(string[] args) {
            string filePath = "../../txtInputFile.txt";
            string[] linesFromFile = File.ReadAllLines(filePath);

            for (int counter = 0; counter < linesFromFile.Length; counter++)
            {
                Console.Write(linesFromFile[counter]);
            }
        }
    }
}
