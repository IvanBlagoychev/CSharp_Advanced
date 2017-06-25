using System;
using System.Linq;



public static class SortEvenNumbers
{
    static void Main()
    {
        //var input = Console.ReadLine().Split(',');
        //var list = new List<int>();
        //input.Select(n => int.Parse(n)).Where(n => n % 2 == 0).ToList().ForEach(n => list.Add(n));
        //if(list.Count > 0) Console.WriteLine(string.Join(", ", list.OrderBy(n => n)));

        var result = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(n => n % 2 == 0)
            .OrderBy(n => n);
        Console.WriteLine(string.Join(", ", result));
    }
}