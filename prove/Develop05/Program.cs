using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Eternal Quest Program");
        Console.WriteLine();
        int userInput = 1;
        while (userInput != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.Write("Select a choice from the menu: ");
            string stringUserInput = Console.ReadLine();
            int.TryParse(stringUserInput, out userInput);
            
            if (userInput == 1)
            {
               

               

            }

            else if (userInput == 2)
            {
                
                

            }
            else if(userInput == 3)
            {
                
            }
            else if (userInput == 4)
            {

            }
            else if (userInput == 5)
            {

            }
            
            else if (userInput != 6 && userInput != 5 && userInput != 4 && userInput != 3 && userInput != 2 && userInput != 1)
            {
                Console.WriteLine("This is not a valid option, please try again");
                Thread.Sleep(2000);
                Console.Clear();
            
            }
        
           
        }
    }
}