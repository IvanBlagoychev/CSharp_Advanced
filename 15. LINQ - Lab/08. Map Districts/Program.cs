using System;
using System.Collections.Generic;
using System.Linq;


public class MapDistricts
{
    static void Main()
    {
        var towns = new Dictionary<string, List<long>>();
        var input = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < input.Length; i += 2)
        {
            if (!towns.ContainsKey(input[i]))
            {
                var population = new List<long>();
                population.Add(long.Parse(input[i + 1]));
                towns[input[i]] = population;
            }
            else towns[input[i]].Add(int.Parse(input[i + 1]));
        }
        var bound = long.Parse(Console.ReadLine());
        towns = towns.Where(t => t.Value.Sum() > bound)
            .OrderByDescending(t => t.Value.Sum())
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var city in towns)
        {
            var districts = city.Value.OrderByDescending(v => v).Take(5);
            Console.WriteLine(string.Format($"{city.Key}: {string.Join(" ", districts)}"));
        }
    }
}