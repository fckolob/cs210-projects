public abstract class Goal
{
    protected string _name = "";
    protected string _description = ""; 
    protected int _points = 0;
    
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal (string savedString){}
    public string GetName()
    {
        return _name;
    }
    public virtual int RecordEvent()
    {
        return _points;
    }
    
    //public virtual string ToSavedString()   
    //{

    //}
    public override string ToString()
    {
        return $"[]. {_name} ({_description})";
    }
    
   
}