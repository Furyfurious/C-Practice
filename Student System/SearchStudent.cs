namespace Student_System;

public class StudentSearch
{

    public void SearchStudent(School school) // School injection to search for student 
    {
        //Ask the use name of student to be search
        Console.Write("Enter Name Of Student: ");
        string? studentName = Console.ReadLine();

        // check if student name is null or empty if empty return nothing
        if (string.IsNullOrEmpty(studentName)) return;

        //Capitalize student firstname
        studentName = Char.ToUpper(studentName[0]) + studentName.Substring(1).ToLower();

        
        var found = false;

        //loop the whole student list
        for (var i = 0; i < school.students.Count; i++)
        {
            //check if student is found
            if (studentName == school.students[i].StudentFirstname)
            {
                //display student information
                school.Display();
                found = true; // assign found true
                break; // break the loop
            }

        }

        //check if found
        if (!found)
        {
            // if not found display
            Console.WriteLine("Cannot be find");
        }


    }
}