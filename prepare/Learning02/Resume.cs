
public class Resume
{
    public string Name { get; set; }

    public List<Job> MyJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in MyJobs)
        {
            job.ShowJobDetails();
        }
    }
}