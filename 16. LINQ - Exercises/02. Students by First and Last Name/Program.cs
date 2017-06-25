using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentsByFirstnameAndLastname
{
    public struct Students
    {
        public string FirstName;
        public string LastName;
    }

    static void Main()
    {
        var student = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
        var list = new List<Students>();

        while (student[0] != "END")
        {
            var firstName = student[0];
            char f = firstName[0];
            var lastName = student[1];
            char l = lastName[0];
            if (string.Compare(firstName, lastName) < 0)
            {
                Students newStudent;
                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                list.Add(newStudent);
            }
            student = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        list.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
    }
}