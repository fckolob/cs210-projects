using System;

public class Activity
{
    private string _activity;
    private int _duration;
    private string _description;
    public Activity (string activity,  string description)
    {
        _activity = activity;
        _description = description;
    }
    public Activity (){}
    public void CountDown(string message, int seconds)
    {
         Console.Write(message);

            for (int index = seconds; index > 0; index-- )
            {
                
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
    public void DurationQuestion(){
        Console.Write("How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
    }
    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        SpinnerAnimation(10);
        Console.WriteLine();
        Console.WriteLine();
        
        
    }
    
    public void SpinnerAnimation(int durationSpinner)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationSpinner);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }
        
    }
    public void Welcome()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        

    }
    public void WellDone(int listingCount)
    {
        Console.WriteLine("Well done!!");
        SpinnerAnimation(10);
        if (_activity == "Listing")
        {
            Console.WriteLine($"You have listed {listingCount} items");
        }
        else
        {
            Console.WriteLine($"You have completed {_duration} seconds of the {_activity} Activity");
            SpinnerAnimation(10);
            Console.Clear();
        }
    }
    public int GetDuration()
    {
        return _duration;
    }
    
    

}