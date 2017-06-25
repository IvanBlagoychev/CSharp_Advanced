using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, string>();
            while (input != "stop")
            {
                var email = Console.ReadLine();
                if (email.Substring(email.Length-2, 2) != "us" && email.Substring(email.Length - 2, 2) != "uk")
                {
                    dict[input] = email;
                }
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
