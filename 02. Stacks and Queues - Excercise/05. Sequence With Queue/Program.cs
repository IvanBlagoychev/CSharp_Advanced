using System;
using System.Collections.Generic;


public static class SequenceWithQUeue
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Queue<long> queue = new Queue<long>();
        var result = new long[50];
        queue.Enqueue(num);

        for (int i = 0; i < 50; i++)
        {
            long seq = queue.Dequeue();
            result[i] = seq;
            queue.Enqueue(seq + 1);
            queue.Enqueue(2 * seq + 1);
            queue.Enqueue(seq + 2);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}