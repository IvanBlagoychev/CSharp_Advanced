using System;
using System.Collections.Generic;


public static class MaxElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> resultStack = new Stack<int>();
        resultStack.Push(0);
        for (int i = 0; i < n; i++)
        {
            var query = Console.ReadLine();
            if (query[0] == '1')
            {
                var num = int.Parse(query.Substring(2));
                stack.Push(num);
                if (num > resultStack.Peek())
                {
                    resultStack.Push(num);
                }
            }
            else if (query[0] == '2')
            {
                if (stack.Peek() == resultStack.Peek())
                {
                    resultStack.Pop();
                }
                stack.Pop();
            }
            else if (query[0] == '3')
            {
                Console.WriteLine(resultStack.Peek());
            }
        }
    }
}