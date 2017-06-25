using System;
using System.Linq;


public static class NamesLessOrEqualToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        Predicate<string> checkNamesLenght = name => name.Length <= n;
        foreach (var name in names) if (checkNamesLenght(name)) Console.WriteLine(name);
    }
}