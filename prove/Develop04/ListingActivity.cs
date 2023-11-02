using System;
public class ListingActivity : Activity
{
    private string _description;
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private int _responses;
    public ListingActivity(string activity, int duration, string description) : base (activity, duration, description){}
    public string GetDescription(){
        return _description;
    }
    public void RandomListeningPrompt()
    {
        Random random = new Random();
        int randomIndexOneQ = random.Next(0, _prompts.Count);
        string question = _prompts[randomIndexOneQ];
        _prompts.RemoveAt(randomIndexOneQ);
        Console.Write(question);
        SpinnerAnimation(8);
        Console.WriteLine();
    }
    public void UserResponses()
    {
        
    }


}