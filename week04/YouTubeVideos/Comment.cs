public class Comment
{
    private string _author;
    private string _comment;

    public void setComment(string comment, string author)
    {
        _comment = comment;
        _author = author;
    }

    public string getComment()
    {
        return _comment;
    }

    public string getAuthor()
    {
        return _author;
    }


    public override string ToString()
    {
        return $"\"{_comment}\" - {_author}";
    }

}