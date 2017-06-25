using System;
using System.Collections.Generic;
using System.Linq;

public static class ListOfPredicates
{
    static void Main()
    {
        var range = int.Parse(Console.ReadLine());
        var deviders = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var result = new List<int>();
        Func<int, int, bool> filter = (x, d) => x % d == 0;
        for (int i = 1; i <= range; i++)
        {
            bool isDevisible = true;
            foreach (var devider in deviders)
            {
                if (!filter(i,devider)) isDevisible = false;
            }
            if (isDevisible) result.Add(i); 
        }
        Console.WriteLine(string.Join(" ", result));

        //var range = int.Parse(Console.ReadLine());
        //var deviders = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        //Func<int, bool>[] predicates = deviders.Select(d => (Func<int, bool>)(n => n % d == 0)).ToArray();
        //var result = new List<int>();
        //for (int i = 0; i < range; i++)
        //{
        //    bool canBeDivided = true;

        //    foreach (Func<int, bool> predicate in predicates)
        //    {
        //        if (!predicate(i))
        //        {
        //            canBeDivided = false;
        //            break;
        //        }
        //    }
        //    if (canBeDivided)
        //    {
        //        result.Add(i);
        //    }
        //}
        //Console.WriteLine(string.Join(" ", result));
    }
}