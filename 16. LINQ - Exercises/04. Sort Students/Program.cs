using System;
using System.Collections.Generic;
using System.Linq;


class SortByName
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
    }

    static void Main()
    {
        var student = Console.ReadLine().Split(' ');
        var list = new List<Students>();
        while (student[0] != "END")
        {
            Students newStudent;
            newStudent.FirstName = student[0];
            newStudent.LastName = student[1];
            list.Add(newStudent);
            student = Console.ReadLine().Split(' ');
        }
        list.OrderBy(x => x.LastName).ThenByDescending(x => x.FirstName).ToList().ForEach(c => Console.WriteLine(c.FirstName + " " + c.LastName));
    }
}