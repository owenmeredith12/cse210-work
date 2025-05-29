using System.Diagnostics.Contracts;
using System.Net;

public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public void setComments(string comment, string author, string comment1, string author1, string comment2, string author2)
    {
        Comment firstComment = new Comment();
        Comment secondComment = new Comment();
        Comment thirdComment = new Comment();

        firstComment.setComment(comment, author);
        secondComment.setComment(comment1, author1);
        thirdComment.setComment(comment2, author2);

        _comments.Add(firstComment);
        _comments.Add(secondComment);
        _comments.Add(thirdComment);

    }

    public void setVideoDetails(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void displayVideo()
    {

        Console.WriteLine("The title of the video is" + _title);
        Console.WriteLine("The author of the video is" + _author);
        Console.WriteLine("The length(mins) of the video is" + _length);
        for (int i = 0; i < _comments.Count; i++)
        {

            string author = _comments[i].getAuthor();
            string comment = _comments[i].getComment();
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Comment 1: " + comment);
        }

    }

}