using System;
using System.Collections.Generic;


public static class SpecialWords
{
    static void Main()
    {
        var specWords = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine().Split(new char[] { '(', ')', '[', ']', '<', '>', '!', '?', '-', ',', ' ' });
        var dict = new Dictionary<string, int>();

        foreach (var word in specWords)
            dict[word] = 0;

        foreach (var word in text)
            if (dict.ContainsKey(word)) dict[word]++;

        foreach (var item in dict)
            Console.WriteLine($"{item.Key} - {item.Value}");
    }
}