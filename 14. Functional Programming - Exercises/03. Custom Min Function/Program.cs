using System;
using System.Linq;

public static class FindMin
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToArray();
        Func<int[], int> findMin = x => x.Min();
        Console.WriteLine(findMin(nums));
    }
}