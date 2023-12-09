class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_minutes} min) - {GetDetails()}";
    }

    protected virtual string GetDetails()
    {
        return ""; 
    }


}