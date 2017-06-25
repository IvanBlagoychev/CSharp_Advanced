using System;
using System.Collections.Generic;
using System.Linq;

class StudentsByPhoneNumber
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
        public string PhoneNum;
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
            newStudent.PhoneNum = student[2];
            list.Add(newStudent);
            student = Console.ReadLine().Split(' ');
        }
        list.Where(x => x.PhoneNum.StartsWith("02") || x.PhoneNum.StartsWith("+3592")).Select(x => x).ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
    }
}