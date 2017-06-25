using System;
using System.Text.RegularExpressions;


public static class ValidUsernames
{
    static void Main()
    {
        var line = Console.ReadLine();
        var pattern = @"^[\w\d-]{3,16}$";
        while (line != "END")
        {
            var regex = new Regex(pattern);
            var mactches = regex.Matches(line);
            if (mactches.Count > 0) Console.WriteLine("valid");
            else Console.WriteLine("invalid");
            line = Console.ReadLine();
        }
    }
}