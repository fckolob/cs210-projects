public class SimpleGoal : CompletableGoal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points){}
    public SimpleGoal (string savedString) : base(savedString){}
    //public int RecordEvent()
   // {
        
    //}
}