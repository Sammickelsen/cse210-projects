public class Scripture
{
    public List<Word> ScriptureList;

    private string _reference;

    public Scripture(string reference, List<Word> ScripList)
    {
        ScriptureList = ScripList;
        _reference = reference;
    }

    public string GetRenderedText()
    {
        string renderedText = "";

        foreach (Word word in ScriptureList)
        {
            if (word.IsHidden)
            {
                renderedText += word.Hidden();
            }
            else
            {
                renderedText += word.ShowWord();
            }
        }
        return renderedText;
    }

    public void HideWords(List<Word> ScriptureList)
    {
        
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in ScriptureList)
        {
            if (word.IsHidden)
            {
                return false;
            }
        }
        
        return true;
    }


}