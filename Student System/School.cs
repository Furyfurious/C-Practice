using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class School
    {
        List<Students> students = new List<Students>();

        public void Add(string firstname, string lastname, int year)
        {
            students.Add(new Students(firstname, lastname, year));
        }

        public void Display()
        {
            foreach (Students student in students)
            {

                Console.WriteLine();
                Console.WriteLine($"Hello {student.StudentFirstname} {student.StudentLastname} in the year {student.StudentYear}");
            }
        }

        public void Display_ID()
        {
            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"#Student ID:{1 + i}");
                Console.WriteLine($"Name: {students[i].StudentFirstname} {students[i].StudentLastname}");
                Console.WriteLine($"Year: {students[i].StudentYear}");
                Console.WriteLine();
            }
        }

        public void student_ADD()
        {

        }

        public class Students
        {
            public string StudentFirstname { get; set; }
            public string StudentLastname { get; set; }
            public int StudentYear { get; set; }

            public Students(string studentFirstname, string studentLastname, int studentYear)
            {
                StudentFirstname = studentFirstname;
                StudentLastname = studentLastname;
                StudentYear = studentYear;
            }
        }

    }
}
