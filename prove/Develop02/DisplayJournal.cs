using System;
    
    
    public class DisplayJournal
    {
        public string []  _entries = {};
        public void DisplayEntries(string [] entries)
        {
            foreach (string element in entries)
            {
                Console.WriteLine(element);
            }
        }
    }