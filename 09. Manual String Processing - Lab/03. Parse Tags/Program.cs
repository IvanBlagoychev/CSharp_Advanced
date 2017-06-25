using System;

public static class ParseTags
{
    static void Main()
    {
        var input = Console.ReadLine();
        var openingTag = "<upcase>";
        var closingTag = "</upcase>";

        while (input.IndexOf(openingTag) != -1)
        {
            var startIndex = input.IndexOf(openingTag);
            var endIndex = input.IndexOf(closingTag);
            if (endIndex == -1) break;
            var substr = input.Substring(startIndex, endIndex - startIndex + openingTag.Length + 1);
            var upper = substr
                .Replace(openingTag, "")
                .Replace(closingTag, "")
                .ToUpper();

            input = input.Replace(substr, upper);
        }
        Console.WriteLine(input);
    }
}