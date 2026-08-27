using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class Grade
    {
        public void GradeCalculate()
        {

            // Ask user numbers of subjects
            Console.Write("How many is your subject: ");
            var numSub = Convert.ToInt32(Console.ReadLine());

            //store subjects
            var Subjects = new string[numSub];

            // ask the user subjects name
            for(var i=0; i < numSub; i++)
            {
                Console.WriteLine($"Subject #{i+1}");
                Console.Write("Enter Subject Name: ");
                Subjects[i] = Console.ReadLine() ?? "";

                // Edit the subject firstletter to capslock
                Subjects[i] = Char.ToUpper(Subjects[i][0]) + Subjects[i].Substring(1).ToLower();
          
                Console.WriteLine();
            }

            double total = 0; 

            for(var i = 0; i < Subjects.Length; i++)
            {
                try
                {
                    // check if there is error in the program
                    checked
                    {
                        Console.WriteLine("Enter Grade");
                        Console.Write($"{Subjects[i]} Grade: ");
                        var grades = (Convert.ToDouble(Console.ReadLine()));
                        total += grades;
                        Console.WriteLine();
                    }
                    
                }
                // handle error
                catch (FormatException ex)
                {
                    // highlight the error to console
                    DisplayError(ex.Message);
                }
                
            }

            //calculate the average of grades
            var FinalGrade = total / Subjects.Length;

            Console.WriteLine($"Final Grade: {FinalGrade:F2}");
            Console.WriteLine();
        }


        public static void DisplayError(string message)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
