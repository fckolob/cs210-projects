public abstract class CompletableGoal : Goal
{
    private bool _isComplete;
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
        base.RecordEvent();
        SetIsComplete(true);
        return _points;
        
    }
}
