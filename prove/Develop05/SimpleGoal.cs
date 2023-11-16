public class SimpleGoal : CompletableGoal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points){}
    public SimpleGoal (string savedString) : base(savedString)
    {
        string [] contentParts = savedString.Split(",");
        _name = contentParts[0];
        _description = contentParts[1];
        string stringPoints = contentParts[2];
        string isComplete = contentParts[3];
        _points = int.Parse(stringPoints);
        _isComplete = bool.Parse(isComplete);
    }
    //public int RecordEvent()
   // {
        
    //}
}