public class Video
{
    private string _title;
    private string _author;
    private int _lengthInMinutes;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInMinutes)
    {
        _title = title;
        _author = author;
        _lengthInMinutes = lengthInMinutes;
        _comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthMinutes()
    {
        return _lengthInMinutes;
    }
}