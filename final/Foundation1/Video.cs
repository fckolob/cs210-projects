public class Video
{
   private string _title;
   private string _author;
   private int _lenght;
   private List<Comment> _comments = new List<Comment>();
   public Video(string title, string author, int lenght, List<Comment> comments)
   {
        _title = title;
        _author = author;
        _lenght = lenght;
        foreach (Comment comment in comments)
        {
            _comments.Add(comment);
        }  
   }
   public List<Comment>  GetComments()
   {
        return _comments;
   }
   private int GetCommentsNumber()
   {
        return _comments.Count();
   }
    public override string ToString()
    {
        return $"Title of the video: {_title} \n Author: {_author} \n Lenght of the video in seconds: {_lenght} \n Number of comments: {GetCommentsNumber()}";
    }

}