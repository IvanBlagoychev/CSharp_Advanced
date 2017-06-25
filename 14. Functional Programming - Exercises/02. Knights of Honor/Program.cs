using System;
using System.Linq;


public static class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        Action<string> PrintSirs = x => Console.WriteLine($"Sir {x}");
        input.ForEach(x => PrintSirs(x));
    }
}