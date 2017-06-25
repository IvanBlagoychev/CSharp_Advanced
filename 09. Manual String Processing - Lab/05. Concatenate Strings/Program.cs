using System;
using System.Text;


public static class ConcatenateStrings
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            sb.Append(input); sb.Append(" ");
        }
        Console.WriteLine(sb);
    }
}