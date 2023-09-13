using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user his name and last name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        //Show the name in the James bond way
        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}