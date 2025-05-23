using System.Diagnostics.Contracts;

public class Word
{
    private string _word;
    private string _perpWord;

    private bool _isHidden;


    public Word(string word)
    {
        _word = word;
        _perpWord = word;
    }

    public void setWord(string word)
    {
        _word = word;
        _perpWord = word;
    }

    public void setHidden()
    {
        _word = "___";
        _isHidden = true;
    }

    public bool checkHidden()
    {
        return _isHidden;
    }



    public override string ToString()
    {
        return _word;
    }
}