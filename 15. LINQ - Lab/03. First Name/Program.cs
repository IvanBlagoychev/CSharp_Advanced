using System;
using System.Linq;


public static class FirstName
{
    static void Main()
    {
        var names = Console.ReadLine().Split(' ').ToList();
        var letters = Console.ReadLine().Split(' ').Select(l=>char.ToLower(char.Parse(l))).ToArray();

        var result = names.Where(name => Array.IndexOf(letters, Char.ToLower(name[0])) >= 0).OrderBy(x => x).FirstOrDefault();
        
        Console.WriteLine(result == null ? "No match" : result);
    }
}