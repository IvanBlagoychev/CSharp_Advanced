using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var compounds = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in compounds)
                {
                    set.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
