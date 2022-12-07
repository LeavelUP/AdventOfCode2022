using AdventOfCode2022.Day_1;
using AdventOfCode2022.Day_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode2022
{
    class Program
    {
        public static void Main()
        {
            var D1P1 = new CalorieCounter().MaxCalories();
            Console.WriteLine("The Answer for Day 1.1 is: " + D1P1);
            var D1P2 = new CalorieCounter().TopThreeCalories();
            Console.WriteLine("The Answer for Day 1.2 is: " + D1P2 + "\n");

            var D2P1 = new RockPaperScissors().ScoreCalculator();
            Console.WriteLine("The Answer for Day 2.1 is: " + D2P1);
            //var D2P2 = new CalorieCounter().TopThreeCalories();
            //Console.WriteLine("The Answer for Day 1.2 is: " + D2P2 + "\n");
        }
    }
}