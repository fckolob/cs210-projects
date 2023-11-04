using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program");
        Console.WriteLine();
        int userInput = 1;
        while (userInput != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string stringUserInput = Console.ReadLine();
            int.TryParse(stringUserInput, out userInput);
            
            if (userInput == 1)
            {
               BreathingActivity breathing1 = new BreathingActivity();
               breathing1.RunBreathingActivity();

               

            }

            else if (userInput == 2)
            {
                
                RelfectingActivity relfecting1 = new RelfectingActivity();
                relfecting1.RunReflectionActivity();
                

            }
            else if(userInput == 3)
            {
                ListingActivity listing1 = new ListingActivity();
                listing1.RunListingActivity();

            }
            else if (userInput != 4 && userInput != 3 && userInput != 2 && userInput != 1)
            {
                Console.WriteLine("This is not a valid option, please try again");
                Thread.Sleep(2000);
                Console.Clear();
            
            }
        
           
        }
        Activity activity1 = new Activity();
        Console.Clear();
        Console.WriteLine("Thank you for use the mindfullnes program, until the next time");
        activity1.SpinnerAnimation(3);
        


    }
}