using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public class Calculator
    {
        public void Calculate()
        {
            Console.Write("Enter 1st Number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 1st Number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Symbol + - * / : ");
            var symbol = Convert.ToChar(Console.ReadLine());

            var result = calculator(num1, num2, symbol);

            Console.WriteLine($"Calculated: {num1} {symbol} {num2} = {result}");
        }

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

