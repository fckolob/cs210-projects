using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        while (userInput != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string stringUserInput = Console.ReadLine();
            userInput = int.Parse(stringUserInput);
            if (userInput == 1)
            {
               BreathingActivity breathing1 = new BreathingActivity();
               string activity = "Breathing";
               
               int durationSession = breathing1.GetDuration();
               string descriptionSession = breathing1.GetDescription();
               BreathingActivity breathing2 = new BreathingActivity(activity, durationSession, descriptionSession);
               
               breathing2.Welcome(descriptionSession);
               breathing2.DurationQuestion();
               int durationSession2 = breathing2.GetDuration();
               breathing2.GetReady();
               breathing2.BreathInBreathOut(durationSession2);
               breathing2.WellDone();

               

            }

            else if (userInput == 2)
            {
                RelfectingActivity reflecting1 = new RelfectingActivity();
                string activityR = "Reflecting";
                int durationSessionR = reflecting1.GetDuration();
                string descriptionSessionR = reflecting1.GetDescription();
                RelfectingActivity reflecting2 = new RelfectingActivity(activityR, durationSessionR, descriptionSessionR);
                reflecting2.Welcome(descriptionSessionR);
                reflecting2.DurationQuestion();
                int durationSessionR2 = reflecting2.GetDuration();
                reflecting2.GetReady();
                
                reflecting2.RunReflectionActivity(durationSessionR2);
                reflecting2.WellDone();
                

            }
        }


    }
}