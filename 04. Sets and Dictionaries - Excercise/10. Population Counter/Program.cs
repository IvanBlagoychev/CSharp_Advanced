using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, SortedDictionary<string, long>>();
            
            while (input != "report")
            {
                var cities = new SortedDictionary<string, long>();
                var splitedInput = input.Split('|').Select(x=>x.Trim()).ToArray();
                var city = splitedInput[0];
                var country = splitedInput[1];
                var population = splitedInput[2];
                if (!result.ContainsKey(country))
                {
                    cities[city] = long.Parse(population);
                    result[country] = cities;
                }
                else
                {
                    if (result[country].ContainsKey(city))
                    {
                        result[country][city] += long.Parse(population);
                    }
                    else
                    {
                        result[country].Add(city, long.Parse(population));
                    }
                }
                input = Console.ReadLine();
            }
            var orderedCountries = result.OrderByDescending(city => city.Value.Values.Sum());
            foreach (var country in orderedCountries)
            {
                var people = country.Value.Values.ToArray();
                Console.WriteLine($"{country.Key} (total population: {people.Sum()})");
                foreach (var city in country.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
