using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
    public Person(string name, int group)
    {
        this.Name = name;
        this.Group = group;
    }
    public string Name;
    public int Group;
}

class GroupByGroup
{
    static void Main(string[] args)
    {
        var student = Console.ReadLine().Split(' ');
        var list = new List<Person>();
        while (student[0] != "END")
        {
            var name = new StringBuilder();
            name.Append(student[0]).Append(" ").Append(student[1]);
            var group = int.Parse(student[2]);
            Person newPerson = new Person(name.ToString(), group);
            list.Add(newPerson);
            student = Console.ReadLine().Split(' ');
        }
        
        foreach (var p in list.OrderBy(x => x.Group).GroupBy(x=>x.Group, n=>n.Name))
        {
            var groupedStudents = new List<string>();
            foreach (var studentName in p)
            {
                groupedStudents.Add(studentName);
            }
            Console.WriteLine(string.Format("{0} - {1}",p.Key, string.Join(", ", groupedStudents)));
        }
    }
}