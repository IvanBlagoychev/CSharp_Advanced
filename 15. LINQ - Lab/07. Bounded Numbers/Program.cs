using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        var bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int upperBound = bounds.Max();
        int lowerBound = bounds.Min();
        var list = new List<int>();
        var seq = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Where(x => x >= lowerBound && x <= upperBound
        );

        Console.WriteLine(string.Join(" ", seq));
    }
}