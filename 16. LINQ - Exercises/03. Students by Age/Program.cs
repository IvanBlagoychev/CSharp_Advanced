using System;
using System.Collections.Generic;


class StudentsByAge
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }

    static void Main(string[] args)
    {
        var student = Console.ReadLine().Split(' ');
        var list = new List<Students>();

        while (student[0] != "END")
        {
            var firstName = student[0];
            var lastName = student[1];
            var age = int.Parse(student[2]);
            if (age >= 18 && age <=24)
            {
                Students newStudent;
                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                newStudent.Age = age;
                list.Add(newStudent);
            }
            student = Console.ReadLine().Split(' ');
        }
        list.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " " + x.Age));
    }
}