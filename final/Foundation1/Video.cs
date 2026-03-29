public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display() {
        Console.WriteLine($"{_title} ({_lengthInSeconds}s)");
        Console.WriteLine($"***{_author}");
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}