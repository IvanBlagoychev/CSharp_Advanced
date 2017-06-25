using System;
using System.Collections.Generic;

namespace _1.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var str = Console.ReadLine();
            Stack<char> strStack = new Stack<char>(str);
            Console.WriteLine(string.Join("", strStack));
        }
    }
}
