using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            var dict = new SortedDictionary<string, Dictionary<string, int>>();            
            while (input != "end")
            {
                var innerdict = new Dictionary<string, int>();
                
                var splitted = input.Split(' ').ToArray();
                var lastElem = splitted[splitted.Length - 1];
                var username = lastElem.Substring(lastElem.IndexOf("=") + 1, lastElem.Length - (lastElem.IndexOf("=") + 1));
                var IPAdress = splitted[0].Substring(splitted[0].IndexOf("=") + 1, splitted[0].Length - (splitted[0].IndexOf("=") + 1));

                if (!dict.ContainsKey(username))
                {
                    innerdict[IPAdress] = 1;
                    dict.Add(username, innerdict);
                    
                }
                else
                {
                    if (dict[username].ContainsKey(IPAdress))                    
                       dict[username][IPAdress]++;
                    
                    else
                    {
                        innerdict[IPAdress] = 1;
                        dict[username].Add(IPAdress, 1);
                        
                    }
                }
                
                input = Console.ReadLine();
            }
            
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + ":");
                var result = dict[item];

                Console.WriteLine(string.Join(", ", result.Select(x => x.Key + " => " + x.Value).ToArray()) + ".");
            }
        }
    }
}
