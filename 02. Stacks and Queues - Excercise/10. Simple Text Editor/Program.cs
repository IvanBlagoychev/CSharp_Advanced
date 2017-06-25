using System;
using System.Collections.Generic;
using System.Text;


public static class SimpleTextEditor
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        var stack = new Stack<string>();
        var stringBuild = new StringBuilder();

        while (lines-- > 0)
        {
            var inputParams = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputParams[0];
            var value = inputParams.Length > 1 ? inputParams[1] : null;

            switch (command)
            {
                case "1":
                    stack.Push(stringBuild.ToString());
                    stringBuild.Append(value);
                    break;
                case "2":
                    stack.Push(stringBuild.ToString());
                    stringBuild.Length -= int.Parse(value);
                    break;
                case "3":
                    Console.WriteLine(stringBuild[int.Parse(value) - 1]);
                    break;
                case "4":
                    stringBuild = new StringBuilder(stack.Pop());
                    break;
                default:
                    break;
            }
        }
    }
}