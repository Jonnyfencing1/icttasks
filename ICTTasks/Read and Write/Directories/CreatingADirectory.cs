using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Directories
{
    class CreatingADirectory
    {
        public static void writeAllText()
        {
            string filePath = "../../txtInputFile.txt";
            string filelinesToBeWritten = "This is the WriteAllText method in action";
            File.WriteAllText(filePath, filelinesToBeWritten);
        }
        public static void createDirectory()
        {
            string directoryPath = "C:/Sample";
            DirectoryInfo newDirectory = new DirectoryInfo(directoryPath);
            newDirectory.Create();
        }
        static void Main(string[] args)
        {
            writeAllText();
            Console.ReadKey();
            createDirectory();
            Console.ReadKey();
        }
    }
}
