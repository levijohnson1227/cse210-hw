class Swim : Activity
{
    private int _laps;

    public Swim(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return (_laps * 50) / (1000 * .62);
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _minutes) * 60;
    }

    public override double CalculatePace()
    {
        return _minutes / CalculateDistance() ;
    }
    protected override string GetDetails()
    {
        return $"Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}