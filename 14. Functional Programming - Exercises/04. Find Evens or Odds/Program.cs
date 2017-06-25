using System;
using System.Collections.Generic;
using System.Linq;

public static class FindOddOrEven
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int lowerBound = nums[0];
        int upperBound = nums[1];
        string command = Console.ReadLine();        
        var list = new List<int>();        
        Predicate<int> Nums = x => x % 2 == 0;

        switch (command)
        {
            case "odd":
                for (int i = lowerBound; i <= upperBound; i++) if (!Nums(i)) list.Add(i);                
                break;
            case "even":
                for (int i = lowerBound; i <= upperBound; i++) if (Nums(i)) list.Add(i);
                break;
                
        }
        Console.WriteLine(string.Join(" ", list));
    }
}