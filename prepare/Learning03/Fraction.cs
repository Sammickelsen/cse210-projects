using System.Dynamic;

public class Fraction
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


    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";

        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = Convert.ToDouble(_top)/ Convert.ToDouble(_bottom);

        return decimalValue;
    }
}