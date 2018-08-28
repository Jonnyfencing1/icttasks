using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Read
{
    class readAllText
    {
        public static void ReadAllText(string[] args)
        {
            string filePath = "../../txtInputFile.txt";
            string allTextFromFile = File.ReadAllText(filePath);
            Console.Write(allTextFromFile);
        }
    }
}
