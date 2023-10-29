using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("George", "Division");
        string assignment1Summary = assignment1.GetSummary();

        Console.WriteLine(assignment1Summary);
        MathAssigment math1 = new MathAssigment("george", "multiplication","Section 7.3", "Problems 8-19");
        string math1Summary = math1.GetSummary();
        Console.WriteLine(math1Summary);
        string math1HomeworkList = math1.GetHomeworkList();
        Console.WriteLine(math1HomeworkList);
        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II" );
        string writing1Summary = writing1.GetSummary();
        Console.WriteLine(writing1Summary);
        string writing1WritingInformation = writing1.GetWritingInformation();
        Console.WriteLine(writing1WritingInformation);
    }
}