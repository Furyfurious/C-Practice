using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System
{
    public interface IDisplayerror
    {
        void Displayerror(string message);
    }

    public class HighlightError : IDisplayerror
    {
        public void Displayerror(string message)
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
