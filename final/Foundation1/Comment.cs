public class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    public override string ToString()
    {
        return $"Author of the comment: {_name} \n Text of the comment: {_text}";
    }
}