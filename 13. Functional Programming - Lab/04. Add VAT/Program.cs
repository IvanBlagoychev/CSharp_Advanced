using System;
using System.Linq;


public static class AddDDS
{
    static void Main()
    {
        Func<double, double> AddVat = d => (d * 0.2) + d;
        Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList()
            .ForEach(n => Console.WriteLine($"{AddVat(n):f2}"));
    }
}