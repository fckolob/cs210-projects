using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
public class RelfectingActivity : Activity
{
    private string _descritpion = "This activity will help you to reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _prompts = new List<string> {"---Think of a time when you stood ou for someone else.---", "---Think of a time when you did something really difficult.---", "---Think of a time when you helped someone in need.---", "---Think of a time when you did something truly selfless---."};
    
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    

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
        Random random = new Random();
        int randomIndexOne = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomIndexOne];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        _prompts.RemoveAt(randomIndexOne);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
       

    }
    public void ShowQuestions()
    { 
        
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        CountDown("You may begin in...", 5);
        Console.WriteLine();
        
        
        

    }
    public void RandomQuestion()
    {
        Random random = new Random();
        int randomIndexOneQ = random.Next(0, _questions.Count);
        string question = _questions[randomIndexOneQ];
        _questions.RemoveAt(randomIndexOneQ);
        Console.Write(question);
        SpinnerAnimation(1);
        Console.WriteLine();
    }
    public void RunReflectionActivity(int durationR)
    {
        

        List<string> questions2 = _questions.GetRange(0, _questions.Count);
        List<string> prompts2 = _prompts.GetRange(0, _prompts.Count);
        int numberOfQuestions = _questions.Count - 1;
        int numberOfPrompts = _prompts.Count - 1;
        int tracker = 0;
        int promptTracker = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationR);

    
        
        RandomPrompt();
        promptTracker += 1;

        ShowQuestions();
        while (DateTime.Now < endTime)
        {
            if (promptTracker <= numberOfPrompts)
            {
                if (tracker <= numberOfQuestions)
                {
                    RandomQuestion();
                    tracker += 1;
                }
                else
                {
                    _questions = questions2.GetRange(0, questions2.Count);
                    tracker = 0;
                    RandomPrompt();
                    promptTracker += 1;
                    ShowQuestions();
                    RandomQuestion();
                    tracker += 1;
                }
            }
            else
            {
                _prompts = prompts2.GetRange(0, prompts2.Count);
                promptTracker = 0;
                RandomPrompt();
                promptTracker += 1;
                ShowQuestions();
                RandomQuestion();
                tracker += 1;
            }
        }
    }

}