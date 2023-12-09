using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video V1 = new Video("Intro to Javascript", "The Coding Wizard", 400);
        videoList.Add(V1);

        V1.CommentList.Add(new Comment("RandomCarmel", "What a great video, man!"));
        V1.CommentList.Add(new Comment("TalkingStick", "Man you are not good at writing code."));
        V1.CommentList.Add(new Comment("TheBigMamba", "First!"));
        
        

        Video V2 = new Video("How Christ Walked on Water", "ScriptureMaster", 500);
        videoList.Add(V2);

        V2.CommentList.Add(new Comment("JesusLover123", "I always love your insights!"));
        V2.CommentList.Add(new Comment("JohnTheBaptist", "I told you guys he was the real deal!"));
        V2.CommentList.Add(new Comment("MormonMan", "Thanks for always linking the scripture sources"));
        

        Video V3 = new Video("The Perfect HITT workout", "ScupltNation", 800);
        videoList.Add(V3);

        V3.CommentList.Add(new Comment("WorkingChest", "Your videos are so helpful."));
        V3.CommentList.Add(new Comment("Pain&Gains", "I'll start using this week"));
        V3.CommentList.Add(new Comment("TheBigMamba", "First!"));
        
        foreach (var video in videoList)
        {
            video.DisplayVideo();
        }

    }
}