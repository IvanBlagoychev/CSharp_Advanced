using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentSpecialty
{
    public StudentSpecialty(string name, string facultyNum)
    {
        this.SpeciallityName = name;
        this.FacultyNumber = facultyNum;
    }
    public string SpeciallityName;
    public string FacultyNumber;
}

class Student
{
    public Student(string name, string facultyNum)
    {
        this.StudentName = name;
        this.FacultyNumber = facultyNum;
    }
    public string StudentName;
    public string FacultyNumber;
}

class Program
{
    static void Main(string[] args)
    {
        var speciallity = Console.ReadLine().Split(' ');
        var students = new List<Student>();
        var speciallities = new List<StudentSpecialty>();
        while (speciallity[0] != "Student")
        {
            var name = new StringBuilder();
            name.Append(speciallity[0]).Append(" ").Append(speciallity[1]);
            var facultyNum = speciallity[2];
            StudentSpecialty newSpeciallity = new StudentSpecialty(name.ToString(), facultyNum);
            speciallities.Add(newSpeciallity);
            speciallity = Console.ReadLine().Split(' ');
        }
        var student = Console.ReadLine().Split(' ');

        while (student[0] != "END")
        {
            var name = new StringBuilder();
            name.Append(student[1]).Append(" ").Append(student[2]);
            var facultyNum = student[0];
            Student newStudent = new Student(name.ToString(), facultyNum);
            students.Add(newStudent);
            student = Console.ReadLine().Split(' ');
        }
        var sortedResult = speciallities.Join(
            students,
            x => x.FacultyNumber,
            r => r.FacultyNumber,
            (x, r) => new { x.SpeciallityName, x.FacultyNumber, r.StudentName }
            );
        foreach (var row in sortedResult.OrderBy(x=>x.StudentName))
        {
            foreach (var data in row.StudentName)
            {
                Console.WriteLine($"{row.SpeciallityName} {row.FacultyNumber} {row.StudentName}");
            }
        }
    }
}