using System;
using System.Linq;

public static class UpperStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');
        Console.WriteLine(string.Join(" ", words.Select(n => n.ToUpper()).ToList()));
    }
}