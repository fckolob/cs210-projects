public  class Goal
{
    private string _goalName = "";
    private string _goalDescription = ""; 
    private int _goalPoints = 0;
    private bool _accomplished;
    public bool GetAccomplished()
    {
        return _accomplished;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }
    public virtual void StoreGoals(int indexGoal, string[] array, string[]arrayToShow, int check)
    {
        string goalToShow = "";
        string goalToStore = "";
        indexGoal += 1;
        if(_accomplished)
        {
            goalToShow = $"{indexGoal}. [X] {_goalName}: Description: ({_goalDescription}) Points:{_goalPoints}";

        }
        else
        {
            goalToShow = $"{indexGoal}. [] {_goalName}: Description: ({_goalDescription}) Points:{_goalPoints}";
        }
        
    
        goalToStore = $"{indexGoal},{_goalName}:{_goalDescription},{_goalPoints}, {_accomplished}";
          
        arrayToShow = arrayToShow.Append(goalToShow).ToArray();
        array = array.Append(goalToStore).ToArray();
    }
    public virtual void CreateNewGoal(int indexGoal, string[] array, string[] arrayToshow)
    {
        Console.Clear();
        Console.WriteLine("What is the name of your goal?");
        string goalNameSet = Console.ReadLine();
        SetGoalName(goalNameSet);
        Console.WriteLine("What is a short description of it?");
        string goalDescriptionSet = Console.ReadLine();
        SetGoalDescription(goalDescriptionSet);
        Console.WriteLine("What is the amount of points associated with this goal?");
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
        SetGoalPoints(goalPointsSet);
        StoreGoals(indexGoal, array, arrayToshow, 1);

        
    }
    public void SaveGoals(int score, string[] array)
    {
        string fileName;
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
         using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(score);
                foreach (string line in array)
                {
                    outputFile.WriteLine(line);
                }
            }
        
    }
    
    public void SetScore(int score, int points)
    {
        score = score + points;
    }
    public void ShowScore(int score)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine();
    }
    public void LoadGoals()
    {
        string fileName;
        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string [] lineParts = line.Split(":");
            string indexAndName = lineParts[0];
            string content = lineParts[1];
            string [] indexAndNameParts = indexAndName.Split(",");
            string stringIndex = indexAndNameParts[0];
            int index = int.Parse(stringIndex);
            string name = indexAndNameParts[1];
            string [] contentParts = content.Split(",");
            string description = contentParts[0];
            string stringPoints = contentParts[1];
            string accomplished = contentParts[2];
            int points = int.Parse(stringPoints);

            string lineToShow = "";

            Console.WriteLine(lineToShow);
        }
    }
    public void RecordEvent(string [] arrayToStore)
    {
        ListGoalsMenu(arrayToStore);
        Console.WriteLine("Wich goal did you accomplished?");
        string userInputString = Console.ReadLine();
        int userInput;
        int.TryParse(userInputString, out userInput);
        foreach (string goal in arrayToStore)
        {
            string [] goalParts = goal.Split(":");
            string indexAndName = goalParts[0];
            string [] indexAndNameParts = indexAndName.Split(",");
            string index = indexAndNameParts[0];
            string name = indexAndNameParts[1];
            
        }
    }
    public void ListGoals(string[] arrayToShow)
    {
        foreach (string goal in arrayToShow)
        {
            Console.WriteLine(goal);
        }
    }
    public void ListGoalsMenu(string[] arrayToStore)
    {
        Console.WriteLine("The goals are:")
        Console.WriteLine();
        foreach (string goal in arrayToStore)
        {
            string [] goalParts = goal.Split(":");
            string indexAndName = goalParts[0];
            string [] indexAndNameParts = indexAndName.Split(",");
            string index = indexAndNameParts[0];
            string name = indexAndNameParts[1];
            Console.WriteLine($"{index}. {name}");
        }
    }
   
}