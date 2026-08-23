public class Students
{
    public string StudentFirstname { get; set; }
    public string StudentLastname { get; set; }
    public int StudentYear { get; set; }

    public Students(string studentFirstname, string studentLastname, int studentYear)
    {
        StudentFirstname = studentFirstname;
        StudentLastname = studentLastname;
        StudentYear = studentYear;
    }


}