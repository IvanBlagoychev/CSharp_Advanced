using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Decimal_To_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());            
            var stack = new Stack<int>();            
            if (value == 0)
                Console.WriteLine(0);
            else
            {
                while (value > 0)
                {
                    var remainder = value % 2;
                    value = value / 2;
                    stack.Push(remainder);
                }
                Console.WriteLine(string.Join("", stack));
            }

        }
    }
}
