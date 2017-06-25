using System;
using System.Text.RegularExpressions;


public static class ExtractIntegers
{
    static void Main()
    {
        var input = Console.ReadLine();
        var pattern = @"\d+";
        var regex = new Regex(pattern);
        var matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}