using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTTasks.Data_Types
{
    class Scores
    {
        static void Main(string[] args) {
            char codeLevel = 'A';

            string name = "Gery Byrne";

            int highestscore = 2000;

            float averageofhighscores = 450.99f;

            double averageflowscores = 1.7E+3;

            decimal averageamountpaidout = 25.99M;

            bool highestpossiblescorereached = false;

            Console.WriteLine("The Code level for the game is: " + codeLevel);
            Console.WriteLine("The Player name is: " + name);
            Console.WriteLine("The highest score is: " + highestscore);
            Console.WriteLine("The average highest score is: " + averageofhighscores);
            Console.WriteLine("The average of the lowest scores is: " + averageflowscores);
            Console.WriteLine("The average amount of paid out by the game is: " + averageamountpaidout);
            Console.WriteLine("It is " + highestpossiblescorereached + " that the highest achievable game score has been scored by a player");
            Console.ReadKey();
         }
    }
}
