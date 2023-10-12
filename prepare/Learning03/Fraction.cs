class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string isString = $"{_top}/{_bottom}";
        return isString;
    }

    public decimal GetDecimalValue()
    {
        return (decimal)_top / (decimal)_bottom;
    }
}