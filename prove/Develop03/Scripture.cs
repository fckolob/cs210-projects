using System;
using System.Text;
using System.Collections;
using System.Linq;



public class Scripture
{
    private string _reference = "";
    private string _scriptureOne = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    private string _scriptureTwo = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths.";
    private string [] _scriptureOneParts;
    private string [] _scriptureTwoParts;
    private void GetScriptureWords(string scripture, string[] scriptureArray)
    {
        scriptureArray = scripture.Split(" ");
    

    }
    public void HideWords(int referenceNumber)
    {
        if (referenceNumber == 1)
        {
            
            
            Random random = new Random();
            int randomIndexOne = random.Next(0, _scriptureOneParts.Length);
            Console.WriteLine( _scriptureOneParts.Length);
            Console.WriteLine(randomIndexOne);
        
            string wordOne = _scriptureOneParts[randomIndexOne];
            wordOne = new string('_', wordOne.Length);
            
            
            
            for (int index = 0; index < _scriptureOneParts.Length; index++)
            if (_scriptureOneParts[index] == _scriptureOneParts[randomIndexOne])
                _scriptureOneParts[index] = wordOne;
            Console.WriteLine(_scriptureOneParts);
            Console.WriteLine(wordOne);
        }
        else
        {
            
            
            Random randomX = new Random();
            int randomIndexTwo = randomX.Next(0, _scriptureTwoParts.Length);
            string wordTwo = _scriptureTwoParts[randomIndexTwo];
            
            wordTwo = new string('_', wordTwo.Length);
            for (int index = 0; index < _scriptureTwoParts.Length; index++)
            if (_scriptureTwoParts[index] == _scriptureTwoParts[randomIndexTwo])
                _scriptureTwoParts[index] = wordTwo;
        }
        

    }
    public string GetRenderedText(int referenceNumberY)
    {
        string showString;
        if (referenceNumberY == 1)
        {

            showString = string.Join(" ", _scriptureOneParts);
            return showString;
        }
        else
        {
            showString = string.Join(" ", _scriptureTwoParts);
            return showString;
        }
    }
    public bool IsCompletelyHiden(int referenceNumberj, string stringMainReference)
    {
        if(referenceNumberj == 1)
        {

        
            string stringCheckOne = "___ ___ __ _____ ___ ______ ____ __ ____ ___ ____ ________ ____ ____ _________ _________ __ ___ _____ ___ _______ ___ ____ ___________ _____";
            if (stringCheckOne == stringMainReference)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        else
        {
            string stringCheckTwo = "_____ __ ___ ____ ____ ___ _____ ______ ___ ____ ___ ____ _____ ___ ______________ __ ___ ___ ____ ___________ ____ ___ __ _____ ______ ___ ______";
            if (stringCheckTwo == stringMainReference)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public string ShowScripture(int referenceNumberX)
    {
        if (referenceNumberX == 1)
        {
            return _scriptureOne;
        }
        else
        {
            return _scriptureTwo;
        }
        

    }
    public int GetScriptureLenght(int referenceNumberZ)
    {
        int scriptureLenght = 0;
        if (referenceNumberZ == 1)
        {
            scriptureLenght = _scriptureOne.Length;
        
        }
        else
        {
            scriptureLenght = _scriptureTwo.Length;
        }
        return scriptureLenght;
    }
    public void SetScriptureArray(int referencenumberF, string scriptureMain)
    {
        if (referencenumberF == 1)
        {
            _scriptureOneParts = scriptureMain.Split(" ");
        }
        else
        {
            _scriptureTwoParts = scriptureMain.Split(" ");
        } 
    }
    public void CreateScriptureArryContent(int referenceNumberS)
    {
        if (referenceNumberS == 1)
        {
            _scriptureOneParts = _scriptureOne.Split(" ");
        }
        else
        {
            _scriptureTwoParts = _scriptureTwo.Split(" ");
        }
    }

}