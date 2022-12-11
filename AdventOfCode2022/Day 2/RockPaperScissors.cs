using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_2
{
    class RockPaperScissors
    {
        string[] guide = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 2\Guide.txt");
        public int ScoreCalculator()
        {
            Dictionary<char, string> encryption = new Dictionary<char, string>()
            {
                {'A', "Rock"},{'X', "Rock"},
                {'B', "Paper"},{'Y', "Paper"},
                {'C', "Scissors"},{'Z', "Scissors"}
            };

            int score = 0;
            for (int i = 0; i < guide.Count(); i++)
            {
                char[] input = guide[i].ToCharArray();
                if (input[2] == 'X') score += 1;
                else if (input[2] == 'Y') score += 2;
                else if (input[2] == 'Z') score += 3;

                //draw conditions
                if (encryption[input[0]] == encryption[input[2]]) score += 3;
                //win conditions
                else if (encryption[input[0]] == "Rock" && encryption[input[2]] == "Paper" ||
                         encryption[input[0]] == "Paper" && encryption[input[2]] == "Scissors" ||
                         encryption[input[0]] == "Scissors" && encryption[input[2]] == "Rock") score += 6;
                //lose conditions
                else score += 0;
            }
            return score;
        }

        public int NewScoreCalculator()
        {
            int score = 0;
            for (int i = 0; i < guide.Count(); i++)
            {
                char[] input = guide[i].ToCharArray();
                if (input[2] == 'X') score += 0;
                else if (input[2] == 'Y') score += 3;
                else if (input[2] == 'Z') score += 6;

                //conditions we throw Rock (draw rock / win scissors / lose paper)
                if (input[0] == 'A' && input[2] == 'Y' ||
                    input[0] == 'B' && input[2] == 'X' ||
                    input[0] == 'C' && input[2] == 'Z') score += 1;
                //conditions we throw Paper (draw paper / win rock / lose scissors)
                else if (input[0] == 'B' && input[2] == 'Y' ||
                    input[0] == 'C' && input[2] == 'X' ||
                    input[0] == 'A' && input[2] == 'Z') score += 2;
                //conditions we throw scissors (anything else)
                else score += 3;
            }
            return score;
        }
    }
}

