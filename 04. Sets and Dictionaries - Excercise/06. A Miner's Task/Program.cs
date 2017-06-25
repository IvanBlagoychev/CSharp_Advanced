using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                    dict[input] = quantity;
                else dict[input] += quantity;
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
