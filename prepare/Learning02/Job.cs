public class Job
{
   public string JobTitle { get; set; }
   public string JobCompany { get; set; }
   public string TimeSpent { get; set; }
   public Job()
   {

   }

   public void ShowJobDetails()
   {
    Console.WriteLine($"{JobTitle} ({JobCompany}) {TimeSpent}");
   }
}