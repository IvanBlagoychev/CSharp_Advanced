using System;
using System.Linq;


public class FindAndSumInts
{
    static void Main()
    {
        int asInt = 0;
        var input = Console.ReadLine()
            .Split(' ')
            .Select(s => {
                long value;
                bool success = long.TryParse(s, out value);
                return new { value, success };
                })
                .Where(b=>b.success)
                .Select(x=> x.value)
            .ToArray();

        Console.WriteLine(input.Length == 0 ? "No match" : $"{input.Sum()}");
    }
}