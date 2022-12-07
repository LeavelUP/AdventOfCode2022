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
        List<string> strategyGuide = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 2\Guide.txt"));
        Dictionary<char, string> encryption = new Dictionary<char, string>()
        {
            {'A', "Rock"},{'X', "Rock"},
            {'B', "Paper"},{'Y', "Paper"},
            {'C', "Scissors"},{'Z', "Scissors"}
        };

        public int ScoreCalculator()
        {
            int score = 0;
            for (int i = 0; i < strategyGuide.Count(); i++)
            {
                char[] input = strategyGuide[i].ToCharArray();
                if (input[2] == 'X') score += 1;
                else if (input[2] == 'Y') score += 2;
                else if (input[2] == 'Z') score += 3;

                //draw conditions - both inputs(keys) == same value
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

        public int UpdatedScoreCalculator()
        {
            int score = 0;
            for (int i = 0; i < strategyGuide.Count(); i++)
            {
                char[] input = strategyGuide[i].ToCharArray();
                if (input[2] == 'X') score += 1;
                else if (input[2] == 'Y') score += 2;
                else if (input[2] == 'Z') score += 3;
            }
    }
}

