using System;
using System.Collections.Generic;
using System.Linq;


public static class Party
{
    static void Main()
    {
        var comminPeople = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var command = Console.ReadLine().Split(';');
        var filtered = new List<string>();
        var unfiltered = new List<string>();
        while (!command[0].Equals("Print"))
        {

            switch (command[0])
            {
                case "Add filter":
                    if (command[1].Equals("Starts with"))
                    {
                        filtered.AddRange(comminPeople.Where(n => n.StartsWith(command[2])).ToList());
                        comminPeople.RemoveAll(n => n.StartsWith(command[2]));
                    }
                    else if (command[1].Equals("Ends with"))
                    {
                        filtered.AddRange(comminPeople.Where(n => n.EndsWith(command[2])).ToList());
                        comminPeople.RemoveAll(n => n.EndsWith(command[2]));
                    }
                    else if (command[1].Equals("Length"))
                    {
                        filtered.AddRange(comminPeople.Where(n => n.Length == int.Parse(command[2])).ToList());
                        comminPeople.RemoveAll(n => n.Length == int.Parse(command[2]));
                    }
                    else if (command[1].Equals("Contains"))
                    {
                        filtered.AddRange(comminPeople.Where(n => n.Contains(command[2])).ToList());
                        comminPeople.RemoveAll(n => n.Contains(command[2]));
                    }
                    break;
                case "Remove filter":
                    
                    if (command[1].Equals("Starts with"))
                    {
                        unfiltered = filtered.FindAll(x => x.StartsWith(command[2]));
                        comminPeople.AddRange(unfiltered);
                    }
                    else if (command[1].Equals("Ends with"))
                    {
                        unfiltered = filtered.Where(x => x.EndsWith(command[2])).ToList();
                        comminPeople.AddRange(unfiltered);
                    }
                    else if (command[1].Equals("Length"))
                    {
                        unfiltered = filtered.FindAll(x => x.Length.Equals(int.Parse(command[2]))).ToList();
                        comminPeople.AddRange(unfiltered);
                    }
                    else if (command[1].Equals("Contains"))
                    {
                        unfiltered = filtered.FindAll(x => x.Contains(command[2])).ToList();
                        comminPeople.AddRange(unfiltered);
                    }
                    break;
            }
            command = Console.ReadLine().Split(';');
        }
        if (comminPeople.Count != 0) Console.WriteLine(string.Join(" ", comminPeople));
    }
}