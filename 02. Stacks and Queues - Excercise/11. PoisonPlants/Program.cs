using System;
using System.Collections.Generic;
using System.Linq;


public static class PoisonousPlants
{
    public static void Main()
    {
        var plantsAmount = int.Parse(Console.ReadLine());
        var plants = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var days = new int[plantsAmount];
        var proximityStack = new Stack<int>();

        proximityStack.Push(0);
        for (int i = 1; i < plantsAmount; i++)
        {
            int maxDays = 0;

            while (proximityStack.Count > 0
                   && plants[proximityStack.Peek()] >= plants[i])
            {
                maxDays = Math.Max(maxDays, days[proximityStack.Pop()]);
            }

            if (proximityStack.Count > 0)
                days[i] = maxDays + 1;

            proximityStack.Push(i);
        }
        Console.WriteLine(days.Max());
    }
}