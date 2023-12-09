class Comment
{
    public string author { get; set; }
    public string contents { get; set; } 
    
    public Comment(string Author, string Contents)
    {
        author = Author;
        contents = Contents;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {author}");
        Console.WriteLine(contents);
        Console.WriteLine();
    }

    
}