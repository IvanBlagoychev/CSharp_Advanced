using System;
using System.Collections.Generic;


public static class ParkingLot
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        var set = new SortedSet<string>();
        while (inputLine[0] != "END")
        {
            inputLine = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputLine[0];
            var value = inputLine.Length > 1 ? inputLine[1] : null;
            switch (command)
            {
                case "IN": set.Add(value); break;
                case "OUT": set.Remove(value); break;
            }
        }
        if (set.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        else
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}