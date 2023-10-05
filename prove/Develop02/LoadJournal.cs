using System;
using System.IO;
    public class LoadJournal
    {
        
        public void LoadFile( string filename) 
        {
            
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }