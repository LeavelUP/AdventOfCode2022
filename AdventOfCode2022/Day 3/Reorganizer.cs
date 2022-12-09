using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_3
{
    class Reorganizer
    {
        char[] priorities = " abcdefghijklmnopqrstuvwqyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public int ItemPriority(List<string> items)
        {
            int priority = 0;
            foreach (string item in items)
            {
                string one = item.Substring(0, item.Length / 2);
                string two = item.Substring(item.Length / 2, item.Length / 2);

                char itemType = compareCompartments(one, two);
                int itemPriority = Array.IndexOf(priorities, itemType);

                priority += itemPriority;
            }
            return priority;
        }

        public int BadgePriority(List<string> badges)
        {
            int priority = 0;
            for(int i = 0; i < badges.Count; i += 3)
            {
                char badgeType = compareRucksacks(badges[i], badges[i + 1], badges[i + 2]);
                int badgePriority = Array.IndexOf(priorities, badgeType);

                priority += badgePriority;
            }

            return priority;
        }
        
        private char compareCompartments(string compartmentOne, string compartmentTwo)
        {
            char commonItem = ' ';
            foreach(char item in compartmentOne)
            {
                if (compartmentTwo.Contains(item.ToString()))
                {
                    commonItem= item;
                }
            }
            return commonItem;
        }

        private char compareRucksacks(string rucksackOne, string rucksackTwo, string rucksackThree)
        {
            char commonItem = ' ';
            foreach(char item in rucksackOne)
            {
                if (rucksackTwo.Contains(item.ToString()) && rucksackThree.Contains(item.ToString()))
                {
                    commonItem = item;
                }
            }
            return commonItem;
        }
    }
}
