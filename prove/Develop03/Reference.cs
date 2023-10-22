using System;


public class Reference
{
    private string _book1 = "Jhon";
    private string _chapter1 = "3";
    private string _verse1 = "16";
    private string _book2 = "Proverbs";
    private string _chapter2 = "3";
    private string _verse2 = "5";
    private string _endVerse = "6";

    public string ShowReference(int referenceNumberZ)
    {
        if (referenceNumberZ == 1)
        {
            string showRef1 = $"{_book1} chapter {_chapter1}: {_verse1}";
            return showRef1;
        }
        else
        {
            string showRef2 = $"{_book2} chapter {_chapter2}: {_verse2} - {_endVerse}";
            return showRef2;
        }
    }

}