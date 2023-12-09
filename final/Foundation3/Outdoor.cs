class Outdoor: Event
{   
    private string _weatherReport;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherReport) : base(title, description, date, time, address)
    {
        _weatherReport = weatherReport;

    }

    public override string DisplayFullDetails()
    {
        return $"{base.DisplayFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherReport}";
    }
}