namespace Student_System;

public class StudentSearch
{

    public void SearchStudent(School school)
    {
        Console.Write("Enter Name Of Student: ");
        string? studentName = Console.ReadLine();

        if (string.IsNullOrEmpty(studentName)) return;

        studentName = Char.ToUpper(studentName[0]) + studentName.Substring(1).ToLower();

        var found = false;

        for (var i = 0; i < school.students.Count; i++)
        {
            if (studentName == school.students[i].StudentFirstname)
            {
                school.Display();
                found = true;
                break;
            }

        }

        if (!found)
        {
            Console.WriteLine("Cannot be find");
        }


    }
}