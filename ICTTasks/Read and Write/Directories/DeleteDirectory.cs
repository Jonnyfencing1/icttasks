using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Directories
{
    class DeleteDirectory
    {
        public static void deleteDirectory()
        {
            string directoryPath = "C:/Sample1";

            DirectoryInfo deleteDirectory = new DirectoryInfo(directoryPath);
            deleteDirectory.Delete();
        }
        static void Main(string[] args)
        {
        }
    }
}
