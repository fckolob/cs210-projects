using System;
public class BreathingActivity : Activity
{
    private string _description ="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public BreathingActivity(string activity, int duration, string description)
    : base (activity, duration, description)
    {
        SetActivity(activity);

    }
    public BreathingActivity(){}

    public void BreathInBreathOut(int durationB)
    {
        
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationB);

    
        while (DateTime.Now < endTime)
        {
            
            Console.Write("Breath in...");

            for (int index = 6; index > 0; index-- )
            {
                
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();

            Console.Write("Now breath out...");

            for (int index = 6; index > 0; index-- )
            {
                
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();

        }



    }
    public string GetDescription(){
        return _description;
    }


}