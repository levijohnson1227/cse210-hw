using System.Diagnostics.Contracts;

public class Word
{
    private string _wordAsText;
    private string _wordAsUnder;
    public bool WordAsBool;

    public Word(string text)
    {
        _wordAsText = text;
        _wordAsUnder = new string('_', _wordAsText.Length);
        WordAsBool = false;
        
    }

    public string HideWord()
    { 
        WordAsBool = true;
        return _wordAsUnder;
    }

    public bool IsHidden()
    {
        return WordAsBool;
    }    
     public string GetWord()
    {
        return _wordAsText;
    }
}