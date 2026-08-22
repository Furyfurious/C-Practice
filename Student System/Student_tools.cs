using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class Student_tools
    {
        public void Tools()
        {
            Console.WriteLine("#Student Tools");
            Console.WriteLine("(1) Calcualtor");
            Console.WriteLine("(2) Grade Calculator");
            Console.Write("Choose what tool you want: ");
            var choice = Convert.ToInt32(Console.ReadLine());

            var calculator = new Calculator();
            var GradeCalculator = new Grade();
            switch (choice)
            {
                case 1:
                    calculator.Calculate();
                    break;
                case 2:
                    GradeCalculator.GradeCalculate();
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
    }
}
