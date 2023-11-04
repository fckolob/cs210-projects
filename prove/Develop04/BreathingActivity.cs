using System;
using System.Security.Cryptography.X509Certificates;
public class BreathingActivity : Activity
{
    
    
    public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." ){}

    

    public void BreathInBreathOut()
    {
        
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

    
        while (DateTime.Now < endTime)
        {
            
            CountDown("Breath in...", 6);

            Console.WriteLine();

            CountDown("Now breath out in...", 6);

            Console.WriteLine();
            Console.WriteLine();

        }
        



    }
    public void RunBreathingActivity()
    {
        
        Welcome();
        DurationQuestion();
        GetReady();
        BreathInBreathOut();
        WellDone(1);

    }


}