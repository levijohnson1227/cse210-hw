using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Audit Analysis";
        job1.JobCompany = "Home Depot";
        job1.TimeSpent = "2021-2022";
        // job1.ShowJobDetails();

        Job job2 = new Job();
        job2.JobTitle = "Project Manager";
        job2.JobCompany = "Conservice";
        job2.TimeSpent = "2022-Present";
        // job2.ShowJobDetails();

        Resume resume = new Resume();
        resume.Name = "Levi Johnson";
        resume.MyJobs.Add(job1);
        resume.MyJobs.Add(job2);
        
        resume.DisplayResume();

        
    }
}