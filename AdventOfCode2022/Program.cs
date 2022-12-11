using AdventOfCode2022.Day_1;
using AdventOfCode2022.Day_2;
using AdventOfCode2022.Day_3;
using AdventOfCode2022.Day_4;
using AdventOfCode2022.Day_5;
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
            Console.WriteLine("Day 1.1 Answer: " + D1P1);
            var D1P2 = new CalorieCounter().TopThreeCalories();
            Console.WriteLine("Day 1.2 Answer: " + D1P2 + "\n");

            var D2P1 = new RockPaperScissors().ScoreCalculator();
            Console.WriteLine("Day 2.1 Answer: " + D2P1);
            var D2P2 = new RockPaperScissors().NewScoreCalculator();
            Console.WriteLine("Day 2.2 Answer: " + D2P2 + "\n");

            var D3P1 = new Reorganizer().ItemPriority();
            Console.WriteLine("Day 3.1 Answer: " + D3P1);
            var D3P2 = new Reorganizer().BadgePriority();
            Console.WriteLine("Day 3.2 Answer: " + D3P2 + "\n");

            var D4P1 = new CampCleanup().FindContainers();
            Console.WriteLine("Day 4.1 Answer: " + D4P1);
            var D4P2 = new CampCleanup().FindOverlaps();
            Console.WriteLine("Day 4.2 Answer: " + D4P2 + "\n");

            var D5P1 = new SupplyStacks().FindTopCrates();
            Console.WriteLine("Day 5.1 Answer: " + D5P1);
            var D5P2 = new SupplyStacks().CrateMover9001();
            Console.WriteLine("Day 5.2 Answer: " + D5P2 + "\n");
        }
    }
}