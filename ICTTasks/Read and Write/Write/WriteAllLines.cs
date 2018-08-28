using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Write
{
    class WriteAllLines
    {
        public static void writeAllLines(string[] args)
        {
            string filePath = "../../txtInputFile.txt";
            string[] fileLinesToBeWritten = { "Written Line 1", "Written Line 2", "Written line 3" };

            File.WriteAllLines(filePath, fileLinesToBeWritten);
            readAllLines();
        }
    }
}
