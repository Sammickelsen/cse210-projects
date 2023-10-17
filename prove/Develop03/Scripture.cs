using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    public List<Word> ScriptureList;

    private string _reference;

    private List<int> _indexList = new List<int>();



    public Scripture(string reference, List<Word> ScripList)
    {
        ScriptureList = ScripList;
        _reference = reference;
       
        Random random = new Random();
        for (int i = 0; i < ScriptureList.Count(); i++)
        {
            _indexList.Add(i);
        }
    }

    public string GetRenderedText()
    {
        string renderedText = _reference + " ";

        foreach (Word word in ScriptureList)
        {
            if (word.IsHidden == true)
            {
                renderedText += $"{word.Hidden()} ";
            }
            else
            {
                renderedText += $"{word.ShowWord()} ";
            }
        }
        return renderedText;
    }

    public void HideWords()
    {
        Random random = new Random();

        // for (int i = 0; i < 3; i++)
        // {
        //     int index = random.Next(_shownList.Count);
        //     _shownList[index].IsHidden = true;
        //     _shownList.RemoveAt(index);
        // }

        if (_indexList.Count() >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(_indexList.Count());
                ScriptureList[_indexList[index]].HideWord();
                _indexList.RemoveAt(index);
            }
        }
        else if (_indexList.Count() < 3)
        {
            for (int i = 0; i < _indexList.Count(); i++)
            {
                int index = random.Next(_indexList.Count());
                ScriptureList[_indexList[index]].HideWord();
                _indexList.RemoveAt(index);
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        if (_indexList.Count() != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }


}