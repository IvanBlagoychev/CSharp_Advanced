using System;
using System.Collections.Generic;
using System.Linq;


public static class ReverseAndExclude
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        Predicate<int> devide = x => x % n == 0;
        var stack = new Stack<int>();

        foreach (var num in nums) { if (!devide(num)) { stack.Push(num); } }
            
        while (stack.Count != 0)
        {
            if (stack.Count == 1) { Console.WriteLine(stack.Pop()); }
            else { Console.Write(stack.Pop() + " "); }
        }
    }
}