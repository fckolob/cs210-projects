public class CheckListGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted = 0;
    private int _timesToComplete ;
    public CheckListGoal (string name, string description, int points, int timesToComplete, int bonusAmount) : base (name, description, points)
{
    _timesToComplete = timesToComplete;
    _bonusAmount = bonusAmount;
}
public CheckListGoal (string savedString) : base (savedString)
{
    string [] contentParts = savedString.Split(",");
    _name = contentParts[0];
    _description = contentParts[1];
    string stringPoints = contentParts[2];
    string bonusAmountString = contentParts[3];
    _bonusAmount = int.Parse(bonusAmountString);
    _points = int.Parse(stringPoints);
    string timesToCompletestring = contentParts[4];
    _timesToComplete = int.Parse(timesToCompletestring);
    string timesCompletedStringX = contentParts[5];
    _timesCompleted = int.Parse(timesCompletedStringX);
}
    public override string ToString()
    {
        if (_timesCompleted == _timesToComplete)
        {
            return $"[X]. {_name} ({_description} --Currently completed {_timesCompleted}/{_timesToComplete}.)";
        }
        else
        {
            return $"[]. {_name} ({_description}) --Currently completed {_timesCompleted}/{_timesToComplete}";
        }
    }
    public override int RecordEvent()
    {
        
        _timesCompleted = _timesCompleted + 1;        
        if (_timesCompleted == _timesToComplete)
        {
            SetIsComplete(true);
            return _points + _bonusAmount;

        }
        else
        {
            SetIsComplete(false);
            return _points;
        }
        
    }
    public override string ToSavedString()
    {
        return $"{this}:{_name},{_description},{_points},{_bonusAmount},{_timesToComplete},{_timesCompleted}";
    }
}
