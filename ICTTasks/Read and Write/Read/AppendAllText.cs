using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Read
{
    class AppendAllText
    {
        public static void appendAllText(string[] args)
        {
            string filePath = "../../txtInputFile.txt";
            string fileLinesToBeWritten = "This is the AppeandAllTextMethod in action";
            File.AppendAllText(filePath, fileLinesToBeWritten);
            readAllText();
        }
    }
}
