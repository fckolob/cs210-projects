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
            return $"[X]. {_name} ({_description}) --Currently completed {_timesCompleted}/{_timesToComplete}.";
        }
        else
        {
            return $"[]. {_name} ({_description}) --Currently completed {_timesCompleted}/{_timesToComplete}";
        }
    }
    //I added code for showing an animation when you earn the bonus.
    public override int RecordEvent()
    {
        
        _timesCompleted = _timesCompleted + 1;        
        if (_timesCompleted >= _timesToComplete)
        {
            SetIsComplete(true);
            Console.WriteLine($"Congratulations, you earned {_points} points!!!");
            Console.WriteLine($"And you earned a bonus of {_bonusAmount} points!!!");
            List<string> stars = new List<string>();
            stars.Add("**************************");
            stars.Add("  ********************    ");
            stars.Add("    ****************      ");
            stars.Add("      ************        ");
            stars.Add("        ********          ");
            stars.Add("          ****            ");
            stars.Add("           **             ");
            stars.Add("          ****            ");
            stars.Add("        ********          ");
            stars.Add("      ************        ");
            stars.Add("    ****************      ");
            stars.Add("  ********************    ");
            stars.Add("*                        *");
            stars.Add("  *                    *  ");
            stars.Add("    *                *    ");
            stars.Add("      *            *      ");
            stars.Add("        *        *        ");
            stars.Add("          *    *          ");
            stars.Add("            **            ");
            stars.Add("          *    *          ");
            stars.Add("        *        *        ");
            stars.Add("      *            *      ");
            stars.Add("    *                *    ");
            stars.Add("  *                    *  ");
            stars.Add("*                        *");
            stars.Add("{                         ");
            stars.Add("  {                       ");
            stars.Add("    {                     ");
            stars.Add("      {                   ");
            stars.Add("        {                 ");
            stars.Add("          {               ");
            stars.Add("            {             ");
            stars.Add("              {           ");
            stars.Add("                {         ");
            stars.Add("                  {       ");
            stars.Add("                    {     ");
            stars.Add("                      {   ");
            stars.Add("                        { ");
            stars.Add("                          {");
            stars.Add("                        { ");
            stars.Add("                      {   ");
            stars.Add("                    {     ");
            stars.Add("                  {       ");
            stars.Add("                {         ");
            stars.Add("              {           ");
            stars.Add("            {             ");
            stars.Add("          {               ");
            stars.Add("        {                 ");
            stars.Add("          {               ");
            stars.Add("            {             ");
            stars.Add("              {           ");
            stars.Add("                {         ");
            stars.Add("              {           ");
            stars.Add("            {             ");





            Thread.Sleep(2000);
            Console.Clear();
        
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(8);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = stars[i];
                Console.Write(s);
                Console.Write(s);
                Console.Write(s);
                Console.Write(s);
                
                Console.WriteLine();
                Thread.Sleep(16);
            
                i++;
                if (i >= stars.Count())
                {
                    i = 0;
                }
            }
            

    
            return _points + _bonusAmount;
            
            


        }
        else
        {
            SetIsComplete(false);
            Console.WriteLine($"Congratulations, you earned {_points} points");
            return _points;
        }
        
    }
    public override string ToSavedString()
    {
        return $"{this.GetType()}:{_name},{_description},{_points.ToString()},{_bonusAmount.ToString()},{_timesToComplete.ToString()},{_timesCompleted.ToString()}";
    }
    
}
