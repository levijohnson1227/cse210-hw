class Entry 
{
    public string DateTime { get; set; }

    public string Content { get; set; }

    public string Prompt { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateTime} - Prompt: {Prompt}" + "\n" + $"{Content}");
    }
    
}