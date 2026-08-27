using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class Calculator
    {
        private readonly IDisplayerror HighlightError;

        public Calculator(IDisplayerror error)
        {
            HighlightError = error;
        }

        public void Calculate()
        {
            try
            {   // Display calculator application
                Console.Write("Enter 1st Number: ");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 1st Number: ");
                var num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Symbol + - * / : ");
                var symbol = Convert.ToChar(Console.ReadLine());

                var result = calculator(num1, num2, symbol); // method from calculator

                Console.WriteLine($"Calculated: {num1} {symbol} {num2} = {result}");
            }
            //handle exception 
            catch (FormatException ex)
            {
                //method that highlight error message to user
                HighlightError.Displayerror(ex.Message);
            }
        }

        // handle the calculation
        public static double calculator(int num1, int num2, char symbol)
        {
            return symbol switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException($"Invalid Operation {symbol}")
            };
        }


    }
}

