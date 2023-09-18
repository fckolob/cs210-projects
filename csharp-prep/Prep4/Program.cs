using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int inputInt = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when you finished");
        while (inputInt != 0)          
        {
            Console.Write("Enter a number ");
            input = Console.ReadLine();
            inputInt = int.Parse(input);
            if (inputInt != 0)
            {
                numbers.Add(inputInt);
            }
        }
        int result = numbers.AsQueryable().Sum();
        int lenght = numbers.Count;
        int average = result / lenght;
        int highNumber = 0;
        int lowNumber = 1000000000;
        foreach (int numberx in numbers)
        {
            if (numberx > highNumber)
            {
                highNumber = numberx;
            }
            if (numberx < lowNumber && numberx > 0)
            {
                lowNumber = numberx;
            }
        }
        Console.WriteLine($"The sum is {result}");
        Console.WriteLine($"The lenght of the list is {lenght}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {highNumber}");
        Console.WriteLine($"The smallest positive number is {lowNumber}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }
        

    }
}