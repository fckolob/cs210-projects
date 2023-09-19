using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine
            ("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
            }
        static int SquareNumber(int theNumber)
        {
            int squared = theNumber * theNumber;
            return squared;
        }
        static void DisplayResult(string userName, int squared)
        {
            Console.WriteLine($"{userName}, the square of your number is {squared}");
        }
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }   
}