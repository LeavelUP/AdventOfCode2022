using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_4
{
    class CampCleanup
    {
        string[] assignments = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 4\Sections.txt");
        public int FindContainers()
        {
            int badPairs = 0;
            foreach (string assignment in assignments)
            {
                var sections = CreateRanges(assignment);
                var elfOne = sections[0];
                var elfTwo = sections[1];

                if (elfOne.All(x => elfTwo.Contains(x)) || elfTwo.All(x => elfOne.Contains(x)))
                {
                    badPairs++;
                }
            }
            return badPairs;
        }

        public int FindOverlaps()
        {
            int badPairs = 0;
            foreach (string assignment in assignments)
            {
                var sections = CreateRanges(assignment);
                var elfOne = sections[0];
                var elfTwo = sections[1];

                if (elfOne.Any(x => elfTwo.Contains(x)) || elfTwo.Any(x => elfOne.Contains(x)))
                {
                    badPairs++;
                }
            }
            return badPairs;
        }

        private int[][] CreateRanges(string input)
        {
            int[] ints = Array.ConvertAll(input.Split('-', ','), int.Parse);

            int startOne = ints[0];
            int stopOne = ints[1];
            int startTwo = ints[2];
            int stopTwo = ints[3];

            int[] rangeOne = Enumerable.Range(startOne, stopOne - startOne + 1).ToArray();
            int[] rangeTwo = Enumerable.Range(startTwo, stopTwo - startTwo + 1).ToArray();
            int[][] ranges = new int[][] { rangeOne, rangeTwo };

            return ranges;
        }
    }
}
