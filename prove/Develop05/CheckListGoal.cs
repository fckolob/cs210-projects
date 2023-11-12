public class CheckListGoal : Goal
{
    private int _goalTimes = 0;
    private int _goalBonus = 0;
    public void SetGoalTimes(int goalTimes)
    {
        _goalTimes = goalTimes;
    }
    public void SetGoalBonus(int goalBonus)
    {
        _goalBonus = goalBonus;
    }
    public override void StoreGoals(int indexGoal, string[] array, string[] arrayToShow, int check)
    {
        string goalToShow = "";
        string goalToStore = "";
        if(GetAccomplished())
        {
            goalToShow = $"{indexGoal}. [X] {GetGoalName()}: Description: {GetGoalDescription()} Points:{GetGoalPoints()} --Currently completed {_goalTimes}/{_goalTimes}";

        }
        else
        {
            goalToShow = $"{indexGoal}. [] {GetGoalName()}: Description: {GetGoalDescription()} Points:{GetGoalPoints()} --Currently completed {check}/{_goalTimes}";

        }
        
    
        goalToStore = $"{indexGoal},{GetGoalName()}:{GetGoalDescription()},{GetGoalPoints()}, {GetAccomplished()}";
          
        arrayToShow = arrayToShow.Append(goalToShow).ToArray();
        array = array.Append(goalToStore).ToArray();
    }
    public override void CreateNewGoal(int indexGoal, string[] array, string[] arrayToShow)
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
        Console.WriteLine("How many times this should be accomplished for a bonus?");
        string goalTimesString = Console.ReadLine();
        int goalTimesTry = 0;
        int.TryParse(goalTimesString, out goalTimesTry);
        while (goalTimesTry == 0 || goalTimesTry < 0)
        {
            Console.WriteLine("This is not a valid amount of times");
            Console.WriteLine("It should be a positive integer");

            Console.WriteLine("Please try again");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("How many times this should be accomplished for a bonus?");
            goalTimesString = Console.ReadLine();
            int.TryParse(goalTimesString, out goalTimesTry);
        }
        int goalTimesSet = goalTimesTry;
        SetGoalTimes(goalTimesSet);

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string goalBonusString = Console.ReadLine();
        int goalBonusTry = 0;
        int.TryParse(goalBonusString, out goalBonusTry);
        while (goalBonusTry == 0 || goalBonusTry < 0)
        {
            Console.WriteLine("This is not a valid amount of points for the bonus");
            Console.WriteLine("It should be a positive integer");

            Console.WriteLine("Please try again");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            goalBonusString = Console.ReadLine();
            int.TryParse(goalTimesString, out goalBonusTry);
        }
        int goalBonusSet = goalBonusTry;
        SetGoalBonus(goalBonusSet);
        StoreGoals(indexGoal ,array, arrayToShow, 0);

    }
}