using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class Grade
    {
        public void GradeCalculate()
        {
            Console.Write("How many is your subject: ");
            var numSub = Convert.ToInt32(Console.ReadLine());

            List<string> Subjects = new List<string>();

            for(var i=0; i < numSub; i++)
            {
                Console.WriteLine($"Subject #{i+1}");
                Console.Write("Enter Subject Name: ");
                Subjects.Add(Console.ReadLine());

                Subjects[i] = Char.ToUpper(Subjects[i][0]) + Subjects[i].Substring(1).ToLower();
          
                Console.WriteLine();
            }

            double total = 0;

            for(var i = 0; i < Subjects.Count; i++)
            {
                Console.WriteLine("Enter Grade");
                Console.Write($"{Subjects[i]} Grade: ");
                var grades = (Convert.ToDouble(Console.ReadLine()));
                total += grades;
                Console.WriteLine();
            }

            var FinalGrade = total / Subjects.Count;

            Console.WriteLine($"Final Grade: {FinalGrade:F2}");
            Console.WriteLine();
        }
    }
}
