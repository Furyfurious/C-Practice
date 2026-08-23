using System;
using System.Collections.Generic;
using System.Text;
using static Student_System.School;

namespace Student_System
{
    public class School
    {
        Calculator error = new Calculator();
        List<Students> students = new List<Students>();


        public void Display()
        {
            foreach (Students student in students)
            {

                Console.WriteLine();
                Console.WriteLine($"Student Name:{student.StudentFirstname} {student.StudentLastname}");
                Console.WriteLine($"Student Year:{student.StudentYear}");
                Console.WriteLine();
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

        public void AddStudents()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine();
                    Console.Write("Do you want to add student: (yes/no) : ");
                    string ans = Console.ReadLine().ToLower();

                    if (ans != "yes")
                    {
                        break;
                    }

                    Console.Write("How many student do you want to add? : ");
                    int num_Student = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < num_Student; i++)
                    {
                        try
                        {
                            Console.WriteLine($"Student# {i + 1}");
                            Console.Write("Enter student first name: ");
                            string firstname = Console.ReadLine();
                            firstname = char.ToUpper(firstname[0]) + firstname.Substring(1);

                            Console.Write("Enter student last name: ");
                            string lastname = Console.ReadLine();
                            lastname = char.ToUpper(lastname[0]) + lastname.Substring(1);

                            Console.Write("Enter student year: ");
                            int year = Convert.ToInt32(Console.ReadLine());

                            students.Add(new Students(firstname, lastname, year));
                        }

                        catch (FormatException ex)
                        {
                            error.DisplayError(ex.Message);
                        }

                    }
                }

                catch (FormatException ex)
                {
                    
                    error.DisplayError(ex.Message);
                }

                
            }

        }

        
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
