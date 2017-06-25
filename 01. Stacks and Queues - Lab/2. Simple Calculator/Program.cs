using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i+=2)
            {
                if(i == 0)
                {
                    stack.Push(int.Parse(input[i]));
                }
                else
                {
                    switch (input[i - 1])
                    {
                        case "-": stack.Push(stack.Pop() - int.Parse(input[i]));break;
                        case "+": stack.Push(stack.Pop() + int.Parse(input[i])); break;
                        default: break;
                    }
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
