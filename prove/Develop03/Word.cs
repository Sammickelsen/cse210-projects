using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _wordAsText;
    private string _blankWord;
    private bool _isHidden;

    public Word(string word)
    {
        _wordAsText = word;
        
        int length = word.Length;
        for (int i = 0; i < length; i++)
        {
            _blankWord = _blankWord + "_";
        }
        _isHidden = false;
    }

    public string HideWord()
    {
        return "hide word";
    }

    public string ShowWord()
    {
        return "word";
    }

    public void IsHidden()
    {

    }
}