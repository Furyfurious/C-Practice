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

                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(student);
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

            Console.ReadLine();
        }

        static void AddStudent(School student)
        {
            // loop
            while (true)
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

                    Console.WriteLine($"Student# {i + 1}");
                    Console.Write("Enter student first name: ");
                    string firstname = Console.ReadLine();
                    firstname = char.ToUpper(firstname[0]) + firstname.Substring(1);

                    Console.Write("Enter student last name: ");
                    string lastname = Console.ReadLine();
                    lastname = char.ToUpper(lastname[0]) + lastname.Substring(1);

                    Console.Write("Enter student year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    student.Add(firstname, lastname, year);

                }


            }// While loop
        }
    }// clas
}
