using System;
using System.Collections.Generic;
using System.Text;
using static Student_System.School;

namespace Student_System
{
    public class School
    {

        public List<Students> students  = new List<Students>(); // Object of Array Students

        private readonly IDisplayerror Error; // Injection DisplayError

        public School(IDisplayerror displayerror)
        {
            Error = displayerror;
        }

        
        public void Display() //Display student name
        {
            foreach (Students student in students)
            {

                Console.WriteLine();
                Console.WriteLine($"Student Name:{student.StudentFirstname} {student.StudentLastname}");
                Console.WriteLine($"Student Year:{student.StudentYear}");
                Console.WriteLine();
            }
        }

        public void Display_ID() // Display ID
        {
            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"#Student ID:{1 + i}");
                Console.WriteLine($"Name: {students[i].StudentFirstname} {students[i].StudentLastname}");
                Console.WriteLine($"Year: {students[i].StudentYear}");
                Console.WriteLine();
            }
        }

        public void AddStudents() //Add students
        {
            while (true)
            {

                try
                {
                    Console.WriteLine();

                    //Ask the user to add the students / it
                    Console.Write("Do you want to add student: (yes/no) : ");
                    string ans = Console.ReadLine() ?? "".ToLower() ;

                    //check if the user answer yes or no
                    if (ans != "yes")
                    {
                        // else break the loop
                        break;
                    }

                    // Ask the user how many to add
                    Console.Write("How many student do you want to add? : ");
                    int num_Student = Convert.ToInt32(Console.ReadLine());

                    
                    for (int i = 0; i < num_Student; i++)
                    {
                        try // try to catch any error
                        {
                            Console.WriteLine($"Student# {i + 1}");
                            Console.Write("Enter student first name: ");
                            string firstname = Console.ReadLine() ?? "";

                            // Capitalize the first letter of student name
                            firstname = char.ToUpper(firstname[0]) + firstname.Substring(1); 

                            Console.Write("Enter student last name: ");
                            string lastname = Console.ReadLine() ?? "";
                            lastname = char.ToUpper(lastname[0]) + lastname.Substring(1);

                            Console.Write("Enter student year: ");
                            int year = Convert.ToInt32(Console.ReadLine());

                            // Add to the obj of array students
                            students.Add(new Students(firstname, lastname, year));
                        }

                        catch (FormatException ex) // if catch error
                        {
                            //Display error message
                            Error.Displayerror(ex.Message);
                        }

                    }
                }

                catch (FormatException ex) // if catch error
                {
                    //Display error message
                    Error.Displayerror(ex.Message);
                }

                
            }

        }

        
    }

    

}
