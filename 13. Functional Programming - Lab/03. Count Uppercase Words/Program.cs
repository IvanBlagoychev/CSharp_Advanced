using System;
using System.Linq;


public static class GetUpperCasedLetters
{
    static void Main()
    {
        Func<string, bool> isUpper = x => char.IsUpper(x[0]);
        Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(isUpper)
            .ToList()
            .ForEach(w => Console.WriteLine(w));
    }
}