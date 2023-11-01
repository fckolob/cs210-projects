using System;
public class ListingActivity : Activity
{
    private string _description;
    private string [] _prompts;
    private int _responses;
    public ListingActivity(string activity, int duration, string description) : base (activity, duration, description){}
    public string GetDescription(){
        return _description;
    }
    public void RandomListeningPrompt()
    {

    }
    public void UserResponses()
    {
        
    }


}