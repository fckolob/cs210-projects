using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("St. James and Fork", "New Jersey", "New York", "USA");
        Address address2 = new Address("Karnack and Thot", "Zocer",  "Cairo", "Egypt");
        Address address3 = new Address("Roses and Guns", "New Jersey", "New York", "USA");
        Lectures lectures1 = new Lectures("Black Holes and Curved Time", "A talk presenting the most recent book of the speaker", "8/12/2023", "20:00hs", address1, "Kip Thorne", 500);
        Receptions receptions1 = new Receptions("Celebrating life", "A reception for have fun", "31/12/2023", "23:00hs", address2, "celebrating01@gmail.com" );
        OutdoorGatherings outdoorGatherings1 = new OutdoorGatherings("RC Planes convention", "A great time for sharing the fun for RC planes with outdoor competitions and awards for the best planes and pilots", "27/12/2023", "10:00hs", address3, "This event will cancel in the case of rain or strong winds");
        Console.WriteLine($"Event 1 standard details: {lectures1.StandardDetails()}");
        Console.WriteLine($"Event 1 full details: {lectures1.FullDetails()}");
        Console.WriteLine($"Event 1 short description: {lectures1.ShortDescription()}");
        Console.WriteLine($"Event 2 standard details: {receptions1.StandardDetails()}");
        Console.WriteLine($"Event 2 full details: {receptions1.FullDetails()}");
        Console.WriteLine($"Event 2 short description: {receptions1.ShortDescription()}");
        Console.WriteLine($"Event 3 standard details: {outdoorGatherings1.StandardDetails()}");
        Console.WriteLine($"Event 3 full details: {outdoorGatherings1.FullDetails()}");
        Console.WriteLine($"Event 3 short description: {outdoorGatherings1.ShortDescription()}");

    }
}