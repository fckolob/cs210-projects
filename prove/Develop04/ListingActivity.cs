using System;
public class ListingActivity : Activity
{
    
    private List<string> _prompts = new List<string>{"---Who are people that you appreciate?---", "---What are personal strengths of yours?---", "---Who are people that you have helped this week?---", "---When have you felt the Holy Ghost this month?---", "---Who are some of your personal heroes?---"};
    private int _responses;
    private List<string> _userResponses = new List<string>();
    
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}
    
    public void RandomListingPrompt()
    {
        Random random = new Random();
        int randomIndexOne = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomIndexOne];
        Console.WriteLine("List as many responses You can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        
        Console.WriteLine();
        CountDown("You may begin in...", 5);
        Console.WriteLine();
        Console.WriteLine();
        
    }
    public void UserResponses()
    {
        string userResponse = Console.ReadLine();
        _userResponses.Add(userResponse);
        Console.Clear();

    }
    public int GetResponses()
    {
        return _responses;
    }
    public void RunListingActivity()
    {
        
        Welcome();
        DurationQuestion();
        GetReady();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        RandomListingPrompt();
        while (DateTime.Now < endTime)
        {
            UserResponses();
        }
        _responses = _userResponses.Count;
        WellDone(_responses);
        
        
        
    }


}