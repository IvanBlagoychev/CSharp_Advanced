using System;
using System.Text.RegularExpressions;


public static class CountVowels
{
    static void Main()
    {
        var input = Console.ReadLine();
        var vowels = @"\D";
        var regex = new Regex(vowels);
        int count = regex.Matches(input).Count;
        Console.WriteLine($"Non-digits: {count}");
    }
}

