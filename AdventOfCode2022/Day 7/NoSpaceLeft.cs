using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day_7
{
    public class NoSpaceLeft
    {
        string[] terminalOutput = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 7\TerminalOutputTest.txt");

        public int SumDirectories()
        {
            int directoriesSum = 0;
            List<string> inputs = new List<string>();
            List<string> outputs = new List<string>();
            List<string> directories = new List<string>() { "/" };
            List<string> files = new List<string>();

            foreach (var line in terminalOutput)
            {
                if ( line.StartsWith('$'))
                {
                    inputs.Add(line);
                }
                else
                {
                    outputs.Add(line);
                }
            }
            foreach (var output in outputs)
            {
                if (output.StartsWith("dir"))
                {
                    directories.Add(output.Split(' ').Last());
                }
                else
                {
                    files.Add(output.Split(' ').First());
                }
            }

            foreach (var item in directories) Console.WriteLine(item);

            return directoriesSum;
        }
    }
}
