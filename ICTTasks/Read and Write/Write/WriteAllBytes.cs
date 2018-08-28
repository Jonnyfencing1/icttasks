using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Write
{
    class WriteAllBytes
    {
        public static void writeAllBytes(string[] args)
        {
            rtbOutput.Text = "";
            string filePath = "../../txtInputFile.txt";
            byte[] dataToBeWritten = { 1, 5, 9 };
            File.WriteAllBytes(filePath, dataToBeWritten);
            readAllText();
        }
    }
}
