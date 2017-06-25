using System;
using System.Text.RegularExpressions;


public static class Program
{
    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        Regex regex = new Regex(word);
        int count = regex.Matches(text).Count;
        Console.WriteLine(count);
    }
}
