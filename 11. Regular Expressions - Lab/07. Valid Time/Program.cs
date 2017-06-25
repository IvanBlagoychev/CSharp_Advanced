using System;
using System.Text.RegularExpressions;


public static class ValidTime
{
    static void Main()
    {
        var input = Console.ReadLine();
        var regex = new Regex("(?<hours>[01][0-9]):(?<minutes>[0-6][0-9]):(?<seconds>[0-6][0-9]) (A|P)M");
        while (input != "END")
        {
            Match match = regex.Match(input);
            if (match.Success && IsValidHour(match.Groups["hours"].ToString()))
               Console.WriteLine("valid");            
            else
                Console.WriteLine("invalid");
            input = Console.ReadLine();
        }

    }
    private static bool IsValidHour(string hourToStr)
    {
        var hour = int.Parse(hourToStr);
        return hour <= 12;
    }
}
