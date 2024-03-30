class Video 
{

    public string Title  {get; set;}
    public string Author {get; set;}
    public int Length {get; set;} // in seconds
    private List<Comment> Comments {get; set;}

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int NumberOfComments() 
    {
        return Comments.Count;
    }

    public List<Comment> GetAllComments() 
    {
        return Comments;
    }

    public void AddComment(string name, string text) 
    {
        Comments.Add(new Comment(name, text));
    }
}