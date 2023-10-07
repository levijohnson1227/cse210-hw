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
        PromptList.Add("What was the most unexpected thing that happened to you today?");
        PromptList.Add("Describe a moment when you felt a strong sense of gratitude.?");
        PromptList.Add("Write about a goal you have for the upcoming week and how you plan to achieve it.");

        Random random = new Random();
        int randomIndex = random.Next(0, PromptList.Count);
        string randomPrompt = PromptList[randomIndex];

        return randomPrompt;
    }
}