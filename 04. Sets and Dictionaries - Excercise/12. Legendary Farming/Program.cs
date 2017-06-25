using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var obtained = new Dictionary<string, string>();
            var dict = new Dictionary<string, int>();
            var otherMaterials = new Dictionary<string, int>();
            string winner = string.Empty;

            obtained.Add("shards", "Shadowmourne");
            obtained.Add("fragments", "Valanyr");
            obtained.Add("motes", "Dragonwrath");

            dict.Add("shards", 0);
            dict.Add("fragments", 0);
            dict.Add("motes", 0);

            while (winner == string.Empty)
            {
                var splittedInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 1; i < splittedInput.Length; i += 2)
                {
                    var material = splittedInput[i].ToLower();
                    var quantity = int.Parse(splittedInput[i - 1]);

                    switch (material)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":                            
                             dict[material] += quantity;
                            if (dict[material] >= 250)
                            {
                                winner = material;
                                dict[material] -= 250;
                                Console.WriteLine($"{obtained[material]} obtained!");
                            }
                            break;

                        default:
                            if (!otherMaterials.ContainsKey(material)) otherMaterials[material] = quantity;
                            else otherMaterials[material] += quantity;
                            break;
                    }

                    if (winner != string.Empty) break;
                }
                if (winner != string.Empty) break;
                 
                 input = Console.ReadLine();
            }

            var sortedDict = dict.OrderByDescending(x => x.Value).ThenBy(k=>k.Key);
            foreach (var material in sortedDict)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            var sortedOtherMaterials = otherMaterials.OrderBy(x => x.Key);
            foreach (var material in sortedOtherMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
