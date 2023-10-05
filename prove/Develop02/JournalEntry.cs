using System;
using System.Collections.Generic;
using System.Globalization;
    public class  JournalEntry

    {
        
        public string _date = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        
        
        
        public string GetContent(string prompt, string content)
        {
            
            string contentLine = $"Date: {_date} \nPrompt: {prompt} \n{content}";
            return contentLine;
            
            
            
        }
    }
    
