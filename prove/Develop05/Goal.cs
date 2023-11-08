public  class Goal
{
    private string _goalName = "";
    private string _goalDescription = ""; 
    private int _goalPoints = 0;

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
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
    public virtual void CreateNewGoal()
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

        
    }
    public void SaveGoals(string filename)
    {
        
    }
    public void ShowScore()
    {

    }
    public void LoadGoals(string filename)
    {

    }
    public void RecordEvent()
    {

    }
   
}