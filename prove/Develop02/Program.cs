using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
class Program
{
    
    static void Main(string[] args)
    {
        
        int option = 0;
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write.");
        Console.WriteLine("2. Display.");
        Console.WriteLine("3. Load.");
        Console.WriteLine("4. Save.");
        Console.WriteLine("5. Quit.");
        Console.WriteLine("What would you like to do? ");
        string stringOption = Console.ReadLine();
        option = int.Parse(stringOption);
            
        string [] array = new string[]{};
        while (option != 5)
        {
            
           
            
            if (option == 1)
            {
                
                //The entry is saved with the current date.
                JournalPrompt journal1 = new JournalPrompt();
                string prompted = journal1.RandomPrompt();
                Console.WriteLine(prompted);
                string contentUser = Console.ReadLine();
                JournalEntry entry1 = new JournalEntry();
                string journalLine = entry1.GetContent(prompted, contentUser);
                array = array.Append(journalLine).ToArray();
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write.");
                Console.WriteLine("2. Display.");
                Console.WriteLine("3. Load.");
                Console.WriteLine("4. Save.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine("What would you like to do? ");
                stringOption = Console.ReadLine();
                option = int.Parse(stringOption);
            }
            else if (option == 2)
            {
                
                DisplayJournal display1 = new DisplayJournal();
                display1.DisplayEntries(array);
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write.");
                Console.WriteLine("2. Display.");
                Console.WriteLine("3. Load.");
                Console.WriteLine("4. Save.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine("What would you like to do? ");
                stringOption = Console.ReadLine();
                option = int.Parse(stringOption);
            }
            else if (option == 3)
            {
                
                Console.Write("What is the name of the Journal file ");
                string nameOfFile = Console.ReadLine();
                LoadJournal load1 = new LoadJournal();
                load1.LoadFile(nameOfFile);
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write.");
                Console.WriteLine("2. Display.");
                Console.WriteLine("3. Load.");
                Console.WriteLine("4. Save.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine("What would you like to do? ");
                stringOption = Console.ReadLine();
                option = int.Parse(stringOption);
            }
            else if (option == 4)
            {
                //The entries are saved to a file.
                Console.Write("What is the name of the Journal file ");
                string nameOfFileUser = Console.ReadLine();
                SaveJournal save1 = new SaveJournal();
                save1.Save(nameOfFileUser, array);
                Console.WriteLine($"File saved as {nameOfFileUser}");
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write.");
                Console.WriteLine("2. Display.");
                Console.WriteLine("3. Load.");
                Console.WriteLine("4. Save.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine("What would you like to do? ");
                stringOption = Console.ReadLine();
                option = int.Parse(stringOption);
            }
            else if (option != 5)
            {
                Console.WriteLine("This is not a valid option, please try again");
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write.");
                Console.WriteLine("2. Display.");
                Console.WriteLine("3. Load.");
                Console.WriteLine("4. Save.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine("What would you like to do? ");
                stringOption = Console.ReadLine();
                option = int.Parse(stringOption);
            }
        }
        Console.WriteLine("Until the next entry!");
    }
}