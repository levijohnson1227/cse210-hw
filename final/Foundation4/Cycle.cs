class Cycle : Activity
{
    private double _speed;

    public Cycle(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return (_speed / 60) * _minutes;
    }

    public override double CalculateSpeed()
    {
        return _speed;
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