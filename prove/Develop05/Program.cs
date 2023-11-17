using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        int score = 0;
        List<Goal> goals  = new List<Goal>();

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
                    Console.WriteLine("What is the name or your goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal");
                    int goalPointsTry = 0;
                    string goalPointsString = Console.ReadLine();
        
                    int.TryParse(goalPointsString, out goalPointsTry);
                    while (goalPointsTry == 0 || goalPointsTry < 0)
                    {
                        Console.WriteLine("This is not a valid amount of points");
                        Console.WriteLine("It should be a positive integer");

                        Console.WriteLine("Please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("What is the amount of points associated with this goal?");
                        goalPointsString = Console.ReadLine();
                        int.TryParse(goalPointsString, out goalPointsTry);
                    }
                    int goalPointsSet = goalPointsTry;
                    
                    SimpleGoal simple1 = new SimpleGoal(name, description, goalPointsSet);
                    goals.Add(simple1);
                    userInputGoalInt = -12345;
                }
                else if (userInputGoalInt == 2)
                {
                    Console.WriteLine("What is the name or your goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal");
                    int goalPointsTry = 0;
                    string goalPointsString = Console.ReadLine();
        
                    int.TryParse(goalPointsString, out goalPointsTry);
                    while (goalPointsTry == 0 || goalPointsTry < 0)
                    {
                        Console.WriteLine("This is not a valid amount of points");
                        Console.WriteLine("It should be a positive integer");

                        Console.WriteLine("Please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("What is the amount of points associated with this goal?");
                        goalPointsString = Console.ReadLine();
                        int.TryParse(goalPointsString, out goalPointsTry);
                    }
                    int goalPointsSet = goalPointsTry;
                    
                    EternalGoal eternal1 = new EternalGoal(name, description, goalPointsSet);
                    goals.Add(eternal1);
                    userInputGoalInt = -12345;
                }
                else if (userInputGoalInt == 3)
                {
                    Console.WriteLine("What is the name or your goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal");
                    int goalPointsTry = 0;
                    string goalPointsString = Console.ReadLine();
        
                    int.TryParse(goalPointsString, out goalPointsTry);
                    while (goalPointsTry == 0 || goalPointsTry < 0)
                    {
                        Console.WriteLine("This is not a valid amount of points");
                        Console.WriteLine("It should be a positive integer");

                        Console.WriteLine("Please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("What is the amount of points associated with this goal?");
                        goalPointsString = Console.ReadLine();
                        int.TryParse(goalPointsString, out goalPointsTry);
                    }
                    int goalPointsSet = goalPointsTry;
                    
                    Console.WriteLine("How many times this goal should be accomplished for a bonus?");
                    string stringTimesToComplete = Console.ReadLine();
                    int timesToCompleteTry = 0;
                    int.TryParse(stringTimesToComplete, out timesToCompleteTry);
                    while (timesToCompleteTry == 0 || timesToCompleteTry < 0)
                    {
                        Console.WriteLine("This is not a valid amount of times to be accomplished");
                        Console.WriteLine("It should be a positive integer");

                        Console.WriteLine("Please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("How many times this goal should be accomplished for a bonus?");
                        stringTimesToComplete = Console.ReadLine();
                        int.TryParse(stringTimesToComplete, out timesToCompleteTry);
                    }
                    int timesToCompleteSet = timesToCompleteTry;

                    Console.WriteLine("What is the bonus amount for accomplishing it that many times?");
                    string stringBonusAmount = Console.ReadLine();
                    int bounsAmountTry = 0;
                    int.TryParse(stringBonusAmount, out bounsAmountTry);
                    while (bounsAmountTry == 0 || bounsAmountTry < 0)
                    {
                        Console.WriteLine("This is not a valid amount of points");
                        Console.WriteLine("It should be a positive integer");

                        Console.WriteLine("Please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("What is the bonus for accomplishing it that many times?");
                        stringBonusAmount = Console.ReadLine();
                        int.TryParse(stringBonusAmount, out bounsAmountTry);
                    }
                    int bonusAmountSet = bounsAmountTry;
                    CheckListGoal check1 = new CheckListGoal(name, description, goalPointsSet, timesToCompleteSet, bonusAmountSet);
                    goals.Add(check1);
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
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string stringUserInput = Console.ReadLine();
            int.TryParse(stringUserInput, out userInput);
            

            
            if (userInput == 1)
            {
                
                ShowGoalsKinds();

               

            }

            else if (userInput == 2)
            {
                int indexToShow = 0;
                
                foreach (Goal goal in goals)
                {
                    indexToShow += 1;
                    Console.WriteLine($"{indexToShow}.{goal.ToString()}");
                }
            }
            else if(userInput == 3)
            {
                Console.WriteLine("What is the filename for the goals file");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(score);
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.ToSavedString());
                    }
                }
            }
            else if (userInput == 4)
            {
                int track = 0;
                goals.Clear();
                Console.WriteLine("What is the filename for the goals file");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    track += 1;
                    if (track == 1)
                    {
                        score = int.Parse(line);
                        
                    }
                    else
                    {
                    
                    
                        string [] lineParts = line.Split(":");
                        string goalType= lineParts[0];
                        string content = lineParts[1];
                        if (goalType == "SimpleGoal")
                        {
                            SimpleGoal simple1 = new SimpleGoal(content);
                            goals.Add(simple1);
                        
                        }
                        else if(goalType == "EternalGoal")
                        {
                            EternalGoal eternal1 = new EternalGoal(content);
                            goals.Add(eternal1);
                        }
                        else if(goalType == "CheckListGoal")
                        {
                            CheckListGoal check1 = new CheckListGoal(content);
                            goals.Add(check1);
                        }
                        }
                        

                        
                    

                    
                }
                int indexToShow = 0;
                
                    foreach (Goal goal in goals)
                    {
                        indexToShow += 1;
                        Console.WriteLine($"{indexToShow}.{goal.ToString()}");
                    }
            }
            else if (userInput == 5)
            {
                int indexToShow = 0;
                Console.WriteLine("The goals are:");
                Console.WriteLine();
                
                foreach (Goal goal in goals)
                {
                    indexToShow += 1;
                    Console.WriteLine($"{indexToShow}.{goal.GetName()}");
                }
                Console.WriteLine("Wich goal did you accomplished?");
                int accomplished = int.Parse(Console.ReadLine());
                indexToShow = 0;
                foreach (Goal goal in goals)
                {
                    indexToShow += 1;
                    if (indexToShow == accomplished)
                    {
                        
                        score += goal.RecordEvent();
                    }
                    
                }
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