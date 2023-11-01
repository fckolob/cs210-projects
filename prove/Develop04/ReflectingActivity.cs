using System;
public class RelfectingActivity : Activity
{
    private string _descritpion = "This activity will help you to reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string [] _prompts;
    private string _reflection;
    public RelfectingActivity(string activity, int duration, string description) :base (activity, duration, description)
    {
        SetActivity(activity);

    }
    public RelfectingActivity(){}
    public string GetDescription(){
        return _descritpion;
    }
    public void RandomPrompt()
    {

    }
    public void ShowQuestions()
    {

    }
    

}