using System;
using System.IO;

class Program
{
    static void Main(string[] args)

    {

        void ShowGoalsKinds()
        {
            int userInputGoalInt = 1;
            while (userInputGoalInt != -12345)
            {
                Console.WriteLine("What kind of goal do you want to create?");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Check list goal");
                Console.Write("Select a choice from the menu: ");
                string userInputGoalString = Console.ReadLine();
                int.TryParse(userInputGoalString, out userInputGoalInt);
                if(userInputGoalInt == 1)
                {
                    SimpleGoal simple1 = new SimpleGoal();
                    simple1.CreateNewGoal();
                    userInputGoalInt = -12345;
                }
                else if (userInputGoalInt == 2)
                {
                    EternalGoal eternal1 = new EternalGoal();
                    eternal1.CreateNewGoal();
                    userInputGoalInt = -12345;
                }
                else if (userInputGoalInt == 3)
                {
                    CheckListGoal checkList1 = new CheckListGoal();
                    checkList1.CreateNewGoal();
                    userInputGoalInt = -12345;
                }
                else if (userInputGoalInt != 1 && userInputGoalInt != 2 && userInputGoalInt != 3 && userInputGoalInt != -12345)
                {
                    Console.WriteLine("This is not a valid option, please try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }

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
               ShowGoalsKinds();

               

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