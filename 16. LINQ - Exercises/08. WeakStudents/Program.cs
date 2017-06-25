using System;
using System.Collections.Generic;
using System.Linq;

class WeakStudents
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
        public List<int> Grades;
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
            var grades = new List<int>();
            for (int i = 2; i < student.Length; i++)
            {
                grades.Add(int.Parse(student[i]));
            }
            newStudent.Grades = grades;
            list.Add(newStudent);
            student = Console.ReadLine().Split(' ');
        }
        list.Where(x => x.Grades.Where(z => z <= 3).Count() >= 2).Select(x => x).ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
    }
}