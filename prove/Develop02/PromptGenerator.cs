class PromptGenerator
{
    
    public static string GeneratePrompt()
    {
        List<string> PromptList = new List<string>();
        PromptList.Add("Who was the most interesting person I interacted with today?");
        PromptList.Add("What was the best part of my day?");
        PromptList.Add("How did I see the hand of the Lord in my life today?");
        PromptList.Add("What was the strongest emotion I felt today?");
        PromptList.Add("If I had one thing I could do over today, what would it be?");

        Random random = new Random();
        int randomIndex = random.Next(0, PromptList.Count);
        string randomPrompt = PromptList[randomIndex];

        return randomPrompt;
    }
}