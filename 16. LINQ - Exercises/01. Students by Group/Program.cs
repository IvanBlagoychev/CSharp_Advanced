using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class StudentsByGroup
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
            var firstName = student[0];
            var lastName = student[1];
            if (int.Parse(student[2]).Equals(2))
            {
                Students newStudent;
                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                list.Add(newStudent);
            }
            student = Console.ReadLine().Split(' ');
        }
        list.OrderBy(x => x.FirstName).ThenByDescending(x=>x.LastName).ToList().ForEach(a => Console.WriteLine(a.FirstName + " " + a.LastName));
    }
}