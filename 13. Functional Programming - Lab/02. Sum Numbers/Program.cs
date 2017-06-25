using System;
using System.Linq;


public static class SumNumbers
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        Console.WriteLine(input.Count);
        Console.WriteLine(input.Sum());
    }
}