using System;
using System.Text.RegularExpressions;


    public static class ExtractTags
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var pattern = @"<.*?>";
            while (line != "END")
            {
                var regex = new Regex(pattern);
                if (regex.IsMatch(line))
                {
                    var matches = regex.Matches(line);
                    foreach (Match match in matches)                    
                       Console.WriteLine(match);                    
                }
                line = Console.ReadLine();
            }
        }
    }

