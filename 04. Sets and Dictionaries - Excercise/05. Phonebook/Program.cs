using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, string>();
            while(input[0] != "search")
            {
                dict[input[0]] = input[1];
                input = Console.ReadLine().Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            input = Console.ReadLine().Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "stop")
            {
                if (!dict.ContainsKey(input[0]))
                {
                    Console.WriteLine($"Contact {input[0]} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{input[0]} -> {dict[input[0]]}");
                }
                input = Console.ReadLine().Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
