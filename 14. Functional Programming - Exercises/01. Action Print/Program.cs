using System;
using System.Linq;


public static class PrintNames
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Action<string> print = x => Console.WriteLine(x);
        input.ToList().ForEach(n => print(n));
    }
}