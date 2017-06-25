using System;

public static class RecursiveFibonacci
{
    private static long[] fibNums;

    static void Main(string[] args)
    {
        var nthNum = int.Parse(Console.ReadLine());
        fibNums = new long[nthNum];
        var result = GetFibonacci(nthNum);
        Console.WriteLine(result);
    }

    private static long GetFibonacci(int nthNum)
    {
        if (nthNum <= 2)
        {
            return 1;
        }
        if (fibNums[nthNum - 1] != 0)
        {
            return fibNums[nthNum - 1];
        }
        return fibNums[nthNum - 1] = GetFibonacci(nthNum - 1) + GetFibonacci(nthNum - 2);
    }
}