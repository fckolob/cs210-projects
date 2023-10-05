using System;
using System.Diagnostics.Contracts;
using System.IO;
    public class SaveJournal
    {
        
        public void Save(string fileName, string[] array)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (string line in array)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }