using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ICTTasks.Read_and_Write.Read
{
    class AppendAllLines
    {
        public static void appendAllLines()
        {
            string filePath = "../../txtInputFile.txt";
            string[] fileLinesTOBeWritten = { "Appended Line 1",
                                              "Appeneded Line 2",
                                              "Appended Line 3"
                                            };
            File.AppendAllLines(filePath, fileLinesTOBeWritten);
            readAllLines();
        }
    }
}
