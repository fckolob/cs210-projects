using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        string name1 = "Joseph138";
        string text1 = "I really like that video";
        Comment comment1 = new Comment(name1, text1);
        string name2 ="Rose2023";
        string text2 = "I dont like the video, too bored";
        Comment comment2 = new Comment(name2, text2);
        string name3 = "Miguel625";
        string text3 = "I want to see more of that";
        Comment comment3 = new Comment(name3, text3);
        string name4 = "Julia222";
        string text4 = "I want one like the video shows";
        Comment comment4 = new Comment(name4, text4);
        comments1.Add(comment1);
        comments1.Add(comment2);
        comments1.Add(comment3);
        comments1.Add(comment4);
        Video video1 = new Video("New Fan", "Glenn Curtis", 400, comments1);
        videos.Add(video1);
        List<Comment> comments1A = new List<Comment>();
        string name1A = "Gary138";
        string text1A = "I really like that product that the video shows";
        Comment comment1A = new Comment(name1A, text1A);
        string name2A ="Flint2023";
        string text2A = "I dont like the product, too small";
        Comment comment2A = new Comment(name2A, text2A);
        string name3A = "Rachel625";
        string text3A = "I want to see more details of the showed product";
        Comment comment3A = new Comment(name3A, text3A);
        string name4A = "Susana222";
        string text4A = "I have one of this, and it works very well";
        Comment comment4A = new Comment(name4A, text4A);
        comments1A.Add(comment1A);
        comments1A.Add(comment2A);
        comments1A.Add(comment3A);
        comments1A.Add(comment4A);
        Video video1A = new Video("Great Fan", "Ashley Winter", 700, comments1A);
        videos.Add(video1A);
        List<Comment> comments1B = new List<Comment>();
        string name1B = "Candy138";
        string text1B = "I really need that one";
        Comment comment1B = new Comment(name1B, text1B);
        string name2B ="George2023";
        string text2B = "I prefered AC";
        Comment comment2B = new Comment(name2B, text2B);
        string name3B = "Nick625";
        string text3B = "I want to be in the beach";
        Comment comment3B = new Comment(name3B, text3B);
        string name4B = "Jay222";
        string text4B = "What is the cost?";
        Comment comment4B = new Comment(name4B, text4B);
        comments1B.Add(comment1B);
        comments1B.Add(comment2B);
        comments1B.Add(comment3B);
        comments1B.Add(comment4B);
        Video video1B = new Video("My super fan", "Greg Tyler", 300, comments1B);
        videos.Add(video1B);
        List<Comment> comments1C = new List<Comment>();
        string name1C = "Andy138";
        string text1C = "Who cares?";
        Comment comment1C = new Comment(name1C, text1C);
        string name2C ="Steve2023";
        string text2C = "What is that?";
        Comment comment2C = new Comment(name2C, text2C);
        string name3C = "Gerardo625";
        string text3C = "I liked a lot";
        Comment comment3C = new Comment(name3C, text3C);
        string name4C = "Patricia222";
        string text4C = "Why do you like it so much?";
        Comment comment4C = new Comment(name4C, text4C);
        comments1C.Add(comment1C);
        comments1C.Add(comment2C);
        comments1C.Add(comment3C);
        comments1C.Add(comment4C);
        Video video1C = new Video("The best of the fans", "Jhon Hammond", 1200, comments1C);
        videos.Add(video1C);
        foreach (Video video in videos)
        {
            Console.WriteLine(video.ToString());
            List<Comment> comments = video.GetComments();
            Console.WriteLine("Comments:");
            Console.WriteLine();
            foreach (Comment comment in comments)
            {
                Console.WriteLine(comment.ToString());
            }
        }



    }
}

