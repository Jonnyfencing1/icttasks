using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Read
{
    class readAllBytes
    {
        public static void ReadAllBytes()
        {
            string filePath = "../../txtInputFile.txt";
            byte[] dataFromFile = File.ReadAllBytes(filePath);

            for(int counter = 0; counter < dataFromFile.Length; counter++)
            {
                Console.Write(dataFromFile[counter]);
            }
        }

        static void Main(string[] args)
        {
            ReadAllBytes();
            Console.ReadKey();
        }
    }
}
