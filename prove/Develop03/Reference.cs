public class Reference 
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string Book,string Chapter, string StartVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _startVerse = StartVerse;
    }
    public Reference(string Book,string Chapter, string StartVerse, string EndVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _startVerse = StartVerse;
        _endVerse = EndVerse;
    }

    public string CreateReference()
    {
        string fullReference;
        if (_endVerse != null)
        {
            fullReference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        }
        else
        {
            fullReference = $"{_book} {_chapter}: {_startVerse}";
        }

        return fullReference;
    }
}