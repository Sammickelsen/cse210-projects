using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _wordAsText;
    private string _blankWord;
    public bool IsHidden;

    public Word(string word)
    {
        // Set _wordAsText
        _wordAsText = word;
        
        // Create _blankWord by switching each original letter to
        // an underscore.
        int length = word.Length;
        for (int i = 0; i < length; i++)
        {
            _blankWord = _blankWord + "_";
        }

        // Set the _isHidden bool to false.
        IsHidden = false;
    }

    public string Hidden()
    {
        return _blankWord;
    }

    public string ShowWord()
    {
        return _wordAsText;
    }

    public void HideWord()
    {
        IsHidden = true;
    }
}