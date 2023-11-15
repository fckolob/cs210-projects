public class CheckListGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;
    public CheckListGoal (string name, string description, int points, int timesToComplete, int bonusAmount) : base (name, description, points)
{
    _timesToComplete = timesToComplete;
    _bonusAmount = bonusAmount;
}
public CheckListGoal (string stringSaved) : base (stringSaved){}
    public override string ToString()
    {
        if (_timesCompleted == _timesToComplete)
        {
            return $"[X]. {_name} ({_description} --Currently completed {_timesCompleted}/{_timesToComplete}.)";
        }
        else
        {
            return $"[]. {_name} ({_description} --Currently completed {_timesCompleted}/{_timesToComplete})";
        }
    }
    public override int RecordEvent()
    {
        base.RecordEvent();
        _timesCompleted += 1;        
        if (_timesCompleted == _timesToComplete)
        {
            SetIsComplete(true);
        }
        else
        {
            SetIsComplete(false);
        }
        return _points;
    }
}
