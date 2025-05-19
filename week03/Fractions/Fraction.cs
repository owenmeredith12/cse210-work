public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }


    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int getTop()
    {
        return _top;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string getFractionString()
    {
        string frac = $"{_top}/{_bottom}";
        Console.WriteLine(frac);
        return frac;
    }

    public double getDecimalValue()
    {
        double frac = _top / _bottom;
        Console.WriteLine(frac);
        return frac;
    }
}