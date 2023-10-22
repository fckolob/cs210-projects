using System;

class Program
{
    static void Main(string[] args)
    {   Scripture scripture1 = new Scripture();
        scripture1.CreateScriptureArryContent(1);
        scripture1.CreateScriptureArryContent(2);
        string userOption = "";
        bool check = true;
        
        
            Console.WriteLine("Welcome to the scripture memorize program!");
            Console.WriteLine("What scripture do you want to memorize?");
            Console.WriteLine("Option 1: Jhon 3:16");
            Console.WriteLine("Option 2: Proverbs 3:5-6");
            Console.WriteLine("Type quit if you want to finish the program. ");
            userOption = Console.ReadLine();
            while (userOption != "quit"  || check == false)
            {
                
                if (userOption == "1")
                {
                    
                    int track1 = 0;
                    string show1 = scripture1.ShowScripture(1);
                    Reference reference1 = new Reference();
                    string showRefA = reference1.ShowReference(1);
                    Console.WriteLine(showRefA);
                    Console.WriteLine(show1);
                    Console.WriteLine("Press enter for hide a random word");
                    Console.WriteLine("Type quit for leave");
                    userOption = Console.ReadLine();
                    if (userOption != "quit")
                    {
                        Console.Clear();
                    }
                    
                
                
                    while (track1 < scripture1.GetScriptureLenght(1) || userOption == "quit" || check == false )
                    {
                        
                        scripture1.HideWords(1);
                        string show1A = scripture1.GetRenderedText(1);
                        Console.WriteLine(showRefA);
                        Console.WriteLine(show1A);
                        track1 += 1;
                        scripture1.SetScriptureArray(1, show1A);
                        
                        Console.WriteLine("Press enter for hide a random word");
                        Console.WriteLine("Type quit for leave");
                        userOption = Console.ReadLine();
                        if (userOption != "quit")
                        {
                            Console.Clear();
                            check = scripture1.IsCompletelyHiden(1, show1A);
                        }
                        else
                        {
                            break;
                        }
                        
                        
                        
                    }
                
        
                
                }
                else if (userOption == "2")
                {
        
                    int track2 = 0;
                    string show2 = scripture1.ShowScripture(2);
                    Reference reference2 = new Reference();
                    string showRefB = reference2.ShowReference(2);
                    Console.WriteLine(showRefB);
                    Console.WriteLine(show2);
                    Console.WriteLine("Press enter for hide random words");
                    Console.WriteLine("Type quit for leave");
                    Console.ReadLine();
                    Console.Clear();
                    
                
                
                    while (track2 < scripture1.GetScriptureLenght(2) || userOption == "quit" || check == false)
                    {
                       
                        scripture1.HideWords(2);
                        string show2A = scripture1.GetRenderedText(2);
                        Console.WriteLine(showRefB);
                        Console.WriteLine(show2A);
                        track2 += 1;
                        scripture1.SetScriptureArray(2, show2A);
                        
                        Console.WriteLine("Press enter for hide a random word");
                        Console.WriteLine("Type quit for leave");
                        userOption = Console.ReadLine();
                        if (userOption != "quit")
                        {
                            Console.Clear();
                            check = scripture1.IsCompletelyHiden(2, show2A);
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                
                }
            
            
           
            }
        Console.WriteLine("Thank you for use the scripture memorize program");

        
        
    }
}