using System;
using System.Collections.Generic;


public static class StackFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var stack = new Stack<long>();
        stack.Push(0);
        stack.Push(1);
        for (int i = 1; i < n; i++)
        {
            var num1 = stack.Pop();
            var num2 = stack.Peek();
            stack.Pop();
            stack.Push(num1);
            stack.Push(num1 + num2);
        }
        Console.WriteLine(stack.Peek());
    }
}