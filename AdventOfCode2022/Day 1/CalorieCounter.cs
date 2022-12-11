using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_1
{
    class CalorieCounter
    {
        string[] calories = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 1\Calories.txt");

        public int MaxCalories()
        {
            int currentMax = 0;
            int absoluteMax = 0;
            for (int i = 0; i < calories.Count(); i++)
            {
                if (calories[i] == "" && currentMax > absoluteMax)
                {
                    absoluteMax = currentMax;
                    currentMax = 0;
                }
                else if (calories[i] == "" && currentMax <= absoluteMax)
                {
                    currentMax = 0;
                }
                else
                {
                    currentMax += Convert.ToInt32(calories[i]);
                }

                //capture the last element of the list for comparison
                if (i == calories.Count() - 1 && currentMax > absoluteMax)
                {
                    absoluteMax = currentMax;
                }
            }
            return absoluteMax;
        }

        public int TopThreeCalories()
        {
            int currentMax = 0;
            List<int> caloriesPerElf = new List<int>();
            List<int> maxCalorieElves = new List<int>();
            for (int i = 0; i < calories.Count(); i++)
            {
                if (calories[i] == "")
                {
                    caloriesPerElf.Add(currentMax);
                    currentMax = 0;
                }
                else if (i == calories.Count() - 1)
                {
                    caloriesPerElf.Add(currentMax);
                }
                else
                {
                    currentMax += Convert.ToInt32(calories[i]);
                }                
            }

            for (int i = 0; i < 3; i++)
            {
                int max = caloriesPerElf.Max();
                maxCalorieElves.Add(max);
                caloriesPerElf.Remove(max);
            }
            return maxCalorieElves.Sum();
        }
    }
}
