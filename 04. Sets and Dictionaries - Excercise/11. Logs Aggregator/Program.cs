using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var IP = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);
                var innerDict = new SortedDictionary<string, int>();
                if (!dict.ContainsKey(username))
                {
                    innerDict[IP] = duration;
                    dict[username] = innerDict;
                }
                else if (dict.ContainsKey(username))
                {
                    if (dict[username].ContainsKey(IP))
                    {
                        dict[username][IP] += duration;
                    }
                    else
                    {
                        dict[username].Add(IP, duration);
                    }

                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item}: {dict[item].Values.Sum()} [{string.Join(", ", dict[item].Keys.ToArray())}]");
            }
        }
    }
}
