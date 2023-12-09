using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("30/12/2023", 60, 5);
        activities.Add(running1);
        StationaryBicycles stationaryBicycles1 = new StationaryBicycles("29/12/2023", 50, 30);
        activities.Add(stationaryBicycles1);
        SwimingInTheLapPool swimingInTheLapPool1 = new SwimingInTheLapPool("28/12/2023", 120, 100);
        activities.Add(swimingInTheLapPool1);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}