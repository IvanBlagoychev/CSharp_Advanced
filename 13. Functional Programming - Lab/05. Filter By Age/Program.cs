using System;
using System.Collections.Generic;
using System.Linq;


public static class FilterByAge
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {            
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            dict.Add(input[0], int.Parse(input[1]));
        }
        var condition = Console.ReadLine();
        var ageCondition = int.Parse(Console.ReadLine());
        var format = Console.ReadLine();
        Func<int, bool> check = CheckCondtion(condition, ageCondition);
        Action<KeyValuePair<string, int>> formatPrinter = CreatePrinter(format);
        PrintPeople(dict, check, formatPrinter);

    }
    public static Func<int, bool> CheckCondtion(string condition, int age)
    {
        switch (condition)
        {
            case "younger": return x => x <= age;
            case "older": return x => x >= age;
            default: return null;
        }
    }
    public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
    {
        switch (format)
        {
            case "name": return DictItems => Console.WriteLine($"{DictItems.Key}");
            case "age": return DictItems => Console.WriteLine($"{DictItems.Value}");
            case "name age":  return DictItems => Console.WriteLine($"{DictItems.Key} - {DictItems.Value}");
            default: return null;
        }
    }

    private static void PrintPeople(Dictionary<string, int> people, Func<int, bool> conditionCheck, Action<KeyValuePair<string, int>> printer)
    {
        people.Where(p => conditionCheck(p.Value)).ToList().ForEach(v => printer(v));
    }
}