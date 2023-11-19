public abstract class CompletableGoal : Goal
{
    protected bool _isComplete;
    public CompletableGoal(string name, string description, int points) : base (name, description, points){}
    public CompletableGoal(string savedString) : base(savedString){}
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    //public override string ToSavedString(){}
    public override string ToString()
    {
        if (_isComplete == true)
        {
            return $"[X]. {_name} ({_description})";
        }
        else
        {
            return $"[]. {_name} ({_description})";
        }
    }
    public override int RecordEvent()
    {
        
        SetIsComplete(true);
        Console.WriteLine($"Congratulations, you earned {_points} points!!!");
        return _points;
        
    }
    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_name},{_description},{_points.ToString()},{_isComplete.ToString()}";
    }
}
