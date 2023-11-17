using System.Xml.Linq;

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
    public Goal (string savedString)
    {
        string [] contentParts = savedString.Split(",");
        _name = contentParts[0];
        _description = contentParts[1];
        string stringPoints = contentParts[2];
        
        _points = int.Parse(stringPoints);
        
    }
    public string GetName()
    {
        return _name;
    }
    public virtual int RecordEvent()
    {
        return _points;
    }
    
    public virtual string ToSavedString()
    {
        return $"{this.GetType()}:{_name},{_description},{_points.ToString()}";
    }  
    
    public override string ToString()
    {
        return $"[]. {_name} ({_description})";
    }
    
   
}