using System;
using System.Collections.Generic;
using System.Linq;

public static class ReverseNums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(numbers);
        Console.WriteLine(string.Join(" ", stack));
    }
}