using System;
using System.Reflection.Metadata.Ecma335;

public class  JournalPrompt

    {
        public string[] _promtText = {"How was the most interesting person with you talked today?", "How you tried to be closer to the Lord today?", "How you feel the love of God today?", "What was the most funny thing that happend to you today?", "How you shared time with your family today?"};
        public string RandomPrompt()
        {
            Random prompt = new Random();
            int index = prompt.Next(_promtText.Length);
            string promptShow = _promtText[index];
            return promptShow;
        }
        
    }
