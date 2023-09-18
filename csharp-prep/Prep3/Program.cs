using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 101);
        string response = "yes";
        
        string guess;
        int guessInt;
        int track = 0;
        while (response == "yes")
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
            
            if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
                track += 1;
                
            
            }
            else if (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
                track += 1;
                
            
            }
            else
            {
                track += 1;
                Console.WriteLine("You guessed it,");
                Console.WriteLine($"It took you {track} attemps");
                Console.Write("Do you want to play again? (yes/no) ");
                response = Console.ReadLine();
                track = 0;
                magicNumber = randomgenerator.Next(1, 11);
            }
        }
        Console.WriteLine("Thank you for play this game. Good bye.");

    }
}