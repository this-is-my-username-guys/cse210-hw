using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // 1/1 by reusing the two-number constructor
    public Fraction() : this(1, 1)
    {
    }

    // wholeNumber/1 by reusing the two-number constructor
    public Fraction(int wholeNumber) : this(wholeNumber, 1)
    {
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
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

    // Zero is not allowed as a bottom number, so use 1 instead
    public void SetBottom(int bottom)
    {
        _bottom = (bottom == 0) ? 1 : bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}