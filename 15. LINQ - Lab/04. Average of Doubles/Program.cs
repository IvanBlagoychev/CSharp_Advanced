using System;
using System.Linq;


public class Program
{
    static void Main()
    {
        //var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        //Console.WriteLine($"{nums.Average():f2}");

        Console.WriteLine($"{Console.ReadLine().Split(' ').Select(double.Parse).ToArray().Average():f2}");
    }
}