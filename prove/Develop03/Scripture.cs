using System.Runtime.CompilerServices;

public class Scripture 
{
    private string _reference;
    private List<Word> _scriptureAsList = new List<Word>();
    
    public Scripture(string referenceAsString, string verse)
    {
        _reference = referenceAsString;
        _scriptureAsList = verse.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string DisplayReference()
    {
        return _reference;
    }

    public string DisplayScripture()
    {
        string displayedScripture = "";
        foreach (Word word in _scriptureAsList)
        {
            displayedScripture += word.WordAsBool ? word.HideWord() : word.GetWord();
            displayedScripture += " ";
        }
        return displayedScripture;
    }

    public List<Word> HideWords(string displayedScripture)
    {
       Random random = new Random();
       List<Word> visibleWords = _scriptureAsList.Where(word => !word.IsHidden()).ToList();

       for (int i = 0; i < 3; i++)
       {
         int index = random.Next(visibleWords.Count);
         visibleWords[index].HideWord();
         _scriptureAsList[_scriptureAsList.FindIndex(word => word.GetWord() == visibleWords[index].GetWord())] = visibleWords[index];
       } 

       return _scriptureAsList;    
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _scriptureAsList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}