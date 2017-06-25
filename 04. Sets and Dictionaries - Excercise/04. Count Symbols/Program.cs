using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();
            foreach (var letter in input)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict[letter] = 1;
                }
                else dict[letter]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
