using System;
using System.Collections.Generic;
using System.Linq;


public static class CustomComparator
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        var evenNums = new List<int>();
        var oddNums = new List<int>();
        Predicate<int> check = x => x % 2 == 0;
        foreach (var num in nums)
        {
            if (check(num)) { evenNums.Add(num); }
            else oddNums.Add(num);
        }
        Console.WriteLine(string.Join(" ", evenNums.OrderBy(x => x)) + " " + string.Join(" ", oddNums.OrderBy(x => x)));
    }
}