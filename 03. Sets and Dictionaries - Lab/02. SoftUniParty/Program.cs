using System;
using System.Collections.Generic;


public static class SoftUniParty
{
    static void Main()
    {
        var guest = Console.ReadLine();
        var InvitedGuests = new SortedSet<string>();
        var GuestsWhoCame = new SortedSet<string>();
        while (guest != "PARTY")
        {
            InvitedGuests.Add(guest); guest = Console.ReadLine();
        }
        guest = Console.ReadLine();
        while (guest != "END")
        {
            GuestsWhoCame.Add(guest); guest = Console.ReadLine();
        }

        Console.WriteLine(InvitedGuests.Count - GuestsWhoCame.Count);
        foreach (var person in InvitedGuests)
        {
            if (!GuestsWhoCame.Contains(person))
            {
                Console.WriteLine(person);
            }
        }
    }
}