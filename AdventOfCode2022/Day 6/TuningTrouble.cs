using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AdventOfCode2022.Day_6
{
    public class TuningTrouble
    {
        string[] datastream = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2022\AdventOfCode2022\Day 6\Datastream.txt");
        public int PacketMarkerSubroutine()
        {
            char[] data = new char[] { };
            Queue<char> packet = new Queue<char>();
            bool isUnique = false;
            int packetMarker = 0;
            foreach (var item in datastream)
            {
                data = item.ToCharArray();
            }
            for (int i = 0; i < 4; i++) packet.Enqueue(data[i]);
            isUnique = packet.Distinct().Count() == packet.Count();
            if (isUnique == true)
            {
                packetMarker = 4;
            }
            for (int i = 4; i < data.Length; i++)
            {
                packet.Dequeue();
                packet.Enqueue(data[i]);
                isUnique = packet.Distinct().Count() == packet.Count();
                if (isUnique == true)
                {
                    packetMarker = i+1;
                    break;
                }
            }

            return packetMarker;
        }

        public int MessageMarkerSubroutine()
        {
            char[] data = new char[] { };
            Queue<char> packet = new Queue<char>();
            bool isUnique = false;
            int packetMarker = 0;
            foreach (var item in datastream)
            {
                data = item.ToCharArray();
            }
            for (int i = 0; i < 14; i++) packet.Enqueue(data[i]);
            isUnique = packet.Distinct().Count() == packet.Count();
            if (isUnique == true)
            {
                packetMarker = 14;
            }
            for (int i = 4; i < data.Length; i++)
            {
                packet.Dequeue();
                packet.Enqueue(data[i]);
                isUnique = packet.Distinct().Count() == packet.Count();
                if (isUnique == true)
                {
                    packetMarker = i + 1;
                    break;
                }
            }

            return packetMarker;
        }
    }
}
