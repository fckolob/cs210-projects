public abstract class Goal
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
    public abstract void CreateNewGoal();
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
    public void ShowGoalsKinds()
    {
        int userInputGoalInt = 1;
        while (userInputGoalInt != -12345)
        {
            Console.WriteLine("What kind of goal do you want to create?");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Check list goal");
            Console.WriteLine("3. Eternal goal");
            Console.Write("Select a choice from the menu: ");
            string userInputGoalString = Console.ReadLine();
            int.TryParse(userInputGoalString, out userInputGoalInt);
            if(userInputGoalInt == 1)
            {

                userInputGoalInt = -12345;
            }
            else if (userInputGoalInt == 2)
            {
                userInputGoalInt = -12345;
            }
            else if (userInputGoalInt == 3)
            {
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
}