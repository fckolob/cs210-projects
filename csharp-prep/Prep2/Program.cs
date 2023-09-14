using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage ");
        string userInput = Console.ReadLine();
        int userInputInt = int.Parse(userInput);
        string letter;
        string sign = "";
        
        string message;
        if (userInputInt >= 90)
        {
            letter = "A";
        }
        else if (userInputInt >= 80)
        {
            letter = "B";
              
        }
        else if (userInputInt >= 70)
        {
            letter = "C";
        }
        else if (userInputInt >= 60)
        {
            letter = "D";  
        }
        else
        {
            letter = "F"; 
        }
        if (userInputInt >= 60 && userInputInt < 90 && userInputInt % 10 >= 7)
        {
            sign = "+";
        }
        else if (userInputInt >= 60 && userInputInt % 10 <= 3)
        {
            sign = "-";
        }
        
        if (userInputInt >= 70)
        {
            message = $"Congratulations you aprobed with {letter}{sign}";
        }
        else
        {
            message = $"Good luck for the next time, keep trying and not give up, you reprobed with {letter}{sign}";
        }
        Console.WriteLine($"Your grade is {letter}{sign}.");
        Console.WriteLine(message);

    }   
} 