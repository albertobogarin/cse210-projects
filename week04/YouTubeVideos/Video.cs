public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");

        Console.WriteLine("----- Comments -----");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"{c.GetCommenter()}: {c.GetText()}");
        }
    }
}
