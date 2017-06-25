using System;
using System.Linq;


public class MinEven
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).ToArray();
        Console.WriteLine(nums.Length == 0 ? "No match": $"{nums.Min():f2}");
    }
}