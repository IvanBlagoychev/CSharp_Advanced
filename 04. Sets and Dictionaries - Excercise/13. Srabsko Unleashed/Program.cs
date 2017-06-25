using System;
using System.Collections.Generic;
using System.Linq;


public static class Srabsko
{
    static void Main()
    {
        var input = Console.ReadLine();
        var dict = new Dictionary<string, Dictionary<string, long>>();
        while (input != "End")
        {
            var stats = input.Split(' ').ToArray();
            string singer = string.Empty;

            var venue = string.Empty;
            long tickets = 0;
            long pricePerTicket = 0;
            if (stats.Length >= 4)
            {
                for (int i = 0; i < stats.Length; i++)
                {
                    if (stats[i].StartsWith("@"))
                    {
                        break;
                    }
                    singer += stats[i] + " ";
                }
                var singerName = singer.Split(' ').Select(x => x.Trim()).ToArray();

                for (int i = singerName.Length - 1; i < stats.Length; i++)
                {
                    long num;
                    if (long.TryParse(stats[i], out num))
                    {
                        break;
                    }
                    venue += stats[i] + ' ';
                }
                tickets = long.Parse(stats[stats.Length - 1]);
                pricePerTicket = long.Parse(stats[stats.Length - 2]);

                var innerDict = new Dictionary<string, long>();

                if (!dict.ContainsKey(venue.Substring(1, venue.Length - 1)))
                {
                    innerDict[singer] = tickets * pricePerTicket;
                    dict[venue.Substring(1, venue.Length - 1)] = innerDict;
                }
                else
                {
                    if (!dict[venue.Substring(1, venue.Length - 1)].ContainsKey(singer))
                    {
                        dict[venue.Substring(1, venue.Length - 1)].Add(singer, tickets * pricePerTicket);
                    }
                    else
                    {
                        dict[venue.Substring(1, venue.Length - 1)][singer] += tickets * pricePerTicket;
                    }
                }
            }
            input = Console.ReadLine();
        }

        foreach (var concert in dict)
        {
            Console.WriteLine(concert.Key);
            var sorted = concert.Value.OrderByDescending(v => v.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var singer in sorted)
            {
                Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
            }
        }
    }
}