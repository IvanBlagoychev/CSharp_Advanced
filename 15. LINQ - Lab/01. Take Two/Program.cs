using System;
using System.Linq;


public static class TakeTwo
{
    static void Main()
    {
        var integers = Console.ReadLine().Split(' ').Select(int.Parse);
        Console.WriteLine(string.Join(" ",integers.Where(n=> n >= 10 && n <= 20).Distinct().Take(2).ToList()));
    }
}