using System;
using System.Text.RegularExpressions;


public static class Quotes
{
    static void Main()
    {
        var line = Console.ReadLine();
        var regex = new Regex("(\"|')(.*?)\\1");
        if (regex.IsMatch(line))
        {
            var matches = regex.Matches(line);
            foreach (Match match in matches)
                Console.WriteLine(match.ToString().Substring(1,match.Length - 2));
        }
    }
}

