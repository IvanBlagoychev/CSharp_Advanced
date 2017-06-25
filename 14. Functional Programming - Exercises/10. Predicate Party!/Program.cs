using System;
using System.Collections.Generic;
using System.Linq;


public static class Party
{
    static void Main()
    {
        var comminPeople = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var command = Console.ReadLine().Split(' ');
        while (!command[0].Equals("Party!"))
        {

            switch (command[0])
            {
                case "Remove":
                    if (command[1].Equals("StartsWith")) comminPeople.RemoveAll(n => n.StartsWith(command[2]));
                    else if (command[1].Equals("EndsWith")) comminPeople.RemoveAll(n => n.EndsWith(command[2]));
                    else if (command[1].Equals("Length")) comminPeople.RemoveAll(n => n.Length == int.Parse(command[2]));
                    break;
                case "Double":
                    var doubled = new List<string>();
                    if (command[1].Equals("StartsWith"))
                    {
                        doubled = comminPeople.FindAll(x => x.StartsWith(command[2]));
                            //.Where(x => x.StartsWith(command[2])).Select(e => e).ToList();
                        comminPeople.AddRange(doubled);
                    }
                    else if (command[1].Equals("EndsWith"))
                    {
                        doubled = comminPeople.Where(x => x.EndsWith(command[2])).ToList();
                        comminPeople.AddRange(doubled);
                    }
                    else if (command[1].Equals("Length"))
                    {
                        doubled = comminPeople.Where(x => x.Length.Equals(int.Parse(command[2]))).ToList();
                        comminPeople.AddRange(doubled);
                    }
                    break;
            }
            command = Console.ReadLine().Split(' ');
        }
        if (comminPeople.Count == 0) Console.WriteLine("Nobody is going to the party!");
        else Console.WriteLine($"{string.Join(", ", comminPeople)} are going to the party!");
    }
}