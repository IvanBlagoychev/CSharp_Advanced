using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var setM = new SortedSet<int>();
            var setN = new SortedSet<int>();
            var biggerSet = new SortedSet<int>();
            var smallerSet = new SortedSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                setM.Add(num);
            }
            for (int i = 0; i < input[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                setN.Add(num);
            }
            if (setM.Count > setN.Count)
            {
                biggerSet = setM;
                smallerSet = setN;
            }

            else
            {
                biggerSet = setN;
                smallerSet = setM;
            }

            foreach (var num in biggerSet)
            {
                if (smallerSet.Contains(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
