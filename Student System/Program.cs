namespace Student_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stanciate class school
            var student = new School();
            var isRunning = true;
            var student_tools = new Student_tools();
            while (isRunning)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Display IDs");
                Console.WriteLine("4. Student Tools");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose 1-5");

                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        student.AddStudents();
                        break;

                    case 2:
                        student.Display();
                        break;

                    case 3:
                        student.Display_ID();
                        break;

                    case 4:
                        student_tools.Tools();
                        break;

                    case 5:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }// while loop

      
    }// class
}
