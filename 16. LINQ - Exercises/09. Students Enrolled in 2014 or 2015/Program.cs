using System;
using System.Collections.Generic;
using System.Linq;

class WeakStudents
{
    public struct Students
    {
        public string FacultyNumber;
        public List<int> Grades;
    }

    static void Main()
    {
        var student = Console.ReadLine().Split(' ');
        var list = new List<Students>();

        while (student[0] != "END")
        {

            Students newStudent;
            newStudent.FacultyNumber = student[0];

            var grades = new List<int>();

            for (int i = 1; i < student.Length; i++) grades.Add(int.Parse(student[i]));
            
            newStudent.Grades = grades;
            list.Add(newStudent);

            student = Console.ReadLine().Split(' ');
        }
        list.Where(x=>x.FacultyNumber[4] == '1').Where(x => x.FacultyNumber[5] == '4' || x.FacultyNumber[5] == '5').Select(x => x).ToList().ForEach(x => Console.WriteLine(string.Join(" ", x.Grades)));
    }
}