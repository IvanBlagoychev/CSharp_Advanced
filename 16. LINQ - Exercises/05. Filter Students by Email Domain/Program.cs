using System;
using System.Collections.Generic;
using System.Linq;


class StudentsByEmail
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
        public string Email;
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
            newStudent.Email = student[2];
            list.Add(newStudent);
            student = Console.ReadLine().Split(' ');
        }
        list.Where(x => x.Email.EndsWith("@gmail.com")).Select(x => x).ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
    }
}