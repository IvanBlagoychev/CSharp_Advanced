using System;
using System.Linq;


public static class ParseURLs
{
    static void Main()
    {
        var url = Console.ReadLine().Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        if (url.Length != 2 || url[1].IndexOf("/") == -1)
        {
            Console.WriteLine("Invalid URL");
            return;
        }
        else
        {
            var nextTokens = url[1];
            var protocol = url[0];
            var server = nextTokens.Substring(0, nextTokens.IndexOf("/"));
            var resources = nextTokens.Substring(nextTokens.IndexOf("/") + 1);
            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}