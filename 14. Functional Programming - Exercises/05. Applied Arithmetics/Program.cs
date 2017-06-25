using System;
using System.Linq;


public static class Arithmetics
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
        var command = Console.ReadLine();
        Func<int[], int[]> add = x => x.Select(n => n + 1).ToArray();
        Func<int[], int[]> subtract = x => x.Select(n => n - 1).ToArray();
        Func<int[], int[]> multiply = x => x.Select(n => n * 2).ToArray();

        while (command != "end")
        {
            switch (command)
            {
                case "add":
                    nums = add.Invoke(nums);
                    break;
                case "multiply":
                    nums = multiply.Invoke(nums);
                    break;
                case "subtract":
                    nums = subtract.Invoke(nums);
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", nums));
                    break;
            }
            command = Console.ReadLine();
        }
    }
}