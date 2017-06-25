using System;
using System.Collections.Generic;


public static class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var list = new List<string>();
        for (int i = 0; i < num; i++)
        {
            list.Add(Console.ReadLine().Trim());
        }
        Console.WriteLine(string.Format("{0, -10}|{1, 7}|{2, 7}|{3, 7}|{4, 7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));
        foreach (var item in list)
        {
            var line = item.Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var name = line[0];
            var firstResult = double.Parse(line[1]);
            var secondResult = double.Parse(line[2]);
            var thirdResult = double.Parse(line[3]);
            var average = (firstResult + secondResult + thirdResult) / 3;
            Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", name, firstResult, secondResult, thirdResult, average);

        }
    }
}