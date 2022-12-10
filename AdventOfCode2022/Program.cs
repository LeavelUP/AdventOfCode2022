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
            List<string> calorieList = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 1\Calories.txt"));
            List<string> testCalorieList = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 1\CaloriesTest.txt"));
            var D1P1 = new CalorieCounter().MaxCalories(calorieList);
            var D1P1TEST = new CalorieCounter().MaxCalories(testCalorieList);
            Console.WriteLine("Day 1.1 Test: " + D1P1TEST + " // Day 1.1 Answer: " + D1P1);
            var D1P2 = new CalorieCounter().TopThreeCalories(calorieList);
            var D1P2TEST = new CalorieCounter().TopThreeCalories(testCalorieList);
            Console.WriteLine("Day 1.2 Test: " + D1P2TEST + " // Day 1.2 Answer: " + D1P2 + "\n");

            List<string> strategyGuide = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 2\Guide.txt"));
            List<string> testStrategyGuide = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 2\GuideTest.txt"));
            var D2P1 = new RockPaperScissors().ScoreCalculator(strategyGuide);
            var D2P1TEST = new RockPaperScissors().ScoreCalculator(testStrategyGuide);
            Console.WriteLine("Day 2.1 Test: " + D2P1TEST + " // Day 2.1 Answer: " + D2P1);
            var D2P2 = new RockPaperScissors().NewScoreCalculator(strategyGuide);
            var D2P2TEST = new RockPaperScissors().NewScoreCalculator(testStrategyGuide);
            Console.WriteLine("Day 2.2 Test: " + D2P2TEST + " // Day 2.2 Answer: " + D2P2 + "\n");

            List<string> contents = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 3\Contents.txt"));
            List<string> testContents = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 3\ContentsTest.txt"));
            var D3P1 = new Reorganizer().ItemPriority(contents);
            var D3P1TEST = new Reorganizer().ItemPriority(testContents);
            Console.WriteLine("Day 3.1 Test: " + D3P1TEST + " // Day 3.1 Answer: " + D3P1);
            var D3P2 = new Reorganizer().BadgePriority(contents);
            var D3P2TEST = new Reorganizer().BadgePriority(testContents);
            Console.WriteLine("Day 3.2 Test: " + D3P2TEST + " // Day 3.2 Answer: " + D3P2 + "\n");

            List<string> sections = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 4\Sections.txt"));
            List<string> testSections = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 4\SectionsTest.txt"));
            var D4P1 = new CampCleanup().FindContainers(sections);
            var D4P1TEST = new CampCleanup().FindContainers(testSections);
            Console.WriteLine("Day 4.1 Test: " + D4P1TEST + " // Day 4.1 Answer: " + D4P1);
            var D4P2 = new CampCleanup().FindOverlaps(sections);
            var D4P2TEST = new CampCleanup().FindOverlaps(testSections);
            Console.WriteLine("Day 4.2 Test: " + D4P2TEST + " // Day 4.2 Answer: " + D4P2 + "\n");

            List<string> supplies = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 5\Supplies.txt"));
            List<string> testSupplies = new List<string>(File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 5\SuppliesTest.txt"));
            var D5P1 = new SupplyStacks().FindTopCrates(supplies);
            var D5P1TEST = new SupplyStacks().FindTopCrates(testSupplies);
            Console.WriteLine("Day 5.1 Test: " + D5P1TEST + " // Day 5.1 Answer: " + D5P1);
            var D5P2 = new SupplyStacks();
            var D5P2TEST = new SupplyStacks();
            Console.WriteLine("Day 5.2 Test: " + D5P2TEST + " // Day 5.2 Answer: " + D5P2 + "\n");
        }
    }
}