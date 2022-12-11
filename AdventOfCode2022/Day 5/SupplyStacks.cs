using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_5
{
    public class SupplyStacks
    {
        string[] crates = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 5\Supplies.txt");
        public string FindTopCrates()
        {
            string topCrates = "";
            int numberOfStacks = crates[Array.FindIndex(crates, line => line.StartsWith(" 1"))].Trim().Last() - '0'; //find the count for the number of stacks there are to start
            var startingStack = crates.Take(Array.FindIndex(crates, line => line.StartsWith(" 1"))).ToArray().Reverse(); //find the starting "stack", then reverse it so we can push it to stacks
            string[] instructions = Array.FindAll(crates, line => line.StartsWith("move")); //isolate the instruction messages in the input file
            List<Stack<string>> myStacks = new List<Stack<string>>(); //create a list of Stack objects

            for (int i = 0; i < numberOfStacks; i++)
            {
                myStacks.Add(new Stack<string>()); //create a Stack for each "stack" shown in the input file
            }

            foreach (var line in startingStack) //populate each Stack according to the visual "stack" in the input
            {
                int lineCounter = 0;
                for (int i = 1; i <= line.Length; i += 4) //starting at the first in the line, until we're at the end, jump 4 because of whitespace and brackets
                {
                    string crate = line.ElementAt(i).ToString(); //isolate the crate contents and convert it to a string
                    if (!string.IsNullOrWhiteSpace(crate)) //as long as there's actually a crate in that locations
                    {
                        myStacks.ElementAt(lineCounter).Push(crate); //push the crate into the correct Stack based on the visual "stack"
                    }
                    lineCounter++;
                }
            }

            foreach (var instruction in instructions) //going line by line in the instructions
            {
                string[] moves = instruction.Split(' '); //we need to convert the string into an array
                int numberOfCrates = Int32.Parse(moves[1]); //the number of crates we're moving will always be the second string
                int fromStack = Int32.Parse(moves[3])-1; //the Stack we're popping from will always be the fourth string. "-1" to line up Stack # to List index
                int toStack = Int32.Parse(moves[5])-1; //the Stack we're pushing to will always be the sixth string. "-1" to line up Stack # to List index

                while (numberOfCrates > 0) //so long as we still have moves to do
                {
                    myStacks[toStack].Push(myStacks[fromStack].Pop()); //simultaneously push to one stack what's popped from the other.
                    numberOfCrates--; //reduce the number of moves by one
                }
            }

            foreach (var stack in myStacks) topCrates += stack.First();
            return topCrates;
        }

        public string CrateMover9001()
        {
            string topCrates = "";
            int numberOfStacks = crates[Array.FindIndex(crates, line => line.StartsWith(" 1"))].Trim().Last() - '0';
            var startingStack = crates.Take(Array.FindIndex(crates, line => line.StartsWith(" 1"))).ToArray().Reverse();
            string[] instructions = Array.FindAll(crates, line => line.StartsWith("move"));
            List<Stack<string>> myStacks = new List<Stack<string>>();

            for (int i = 0; i < numberOfStacks; i++)
            {
                myStacks.Add(new Stack<string>());
            }

            foreach (var line in startingStack)
            {
                int lineCounter = 0;
                for (int i = 1; i <= line.Length; i += 4)
                {
                    string crate = line.ElementAt(i).ToString();
                    if (!string.IsNullOrWhiteSpace(crate))
                    {
                        myStacks.ElementAt(lineCounter).Push(crate);
                    }
                    lineCounter++;
                }
            }

            foreach (var instruction in instructions)
            {
                string[] moves = instruction.Split(' ');
                int numberOfCrates = Int32.Parse(moves[1]);
                int fromStack = Int32.Parse(moves[3])-1;
                int toStack = Int32.Parse(moves[5])-1;
                Stack<string> subStack = new Stack<string>(); //we'll use a buffer to ensure the multiple crates stay in the correct order while moving

                while (numberOfCrates > 0)
                {
                    subStack.Push(myStacks[fromStack].Pop());
                    numberOfCrates--;
                }                
                while (subStack.Count() > 0)
                {
                    myStacks[toStack].Push(subStack.Pop());
                }
            }

            foreach (var stack in myStacks) topCrates += stack.First();
            return topCrates;
        }
    }
}
