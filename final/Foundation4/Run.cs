class Run : Activity
{
    private double _distance;

    public Run(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double CalculatePace()
    {
        return _minutes / _distance ;
    }
    protected override string GetDetails()
    {
        return $"Distance: {_distance} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}