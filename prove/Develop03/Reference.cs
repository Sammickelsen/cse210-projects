using System.ComponentModel;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
}