using Splatrika.SquareLibrary.Abstractions;

namespace Splatrika.SquareLibrary;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }


    public Triangle(double a, double b, double c)
    {
        var isRight =
            Math.Round(a * a + b * b, Constants.Precision)
            == Math.Round(c * c, Constants.Precision);
        if (!isRight)
        {
            throw new ArgumentException("Must be a right triangle");
        }

        A = a;
        B = b;
        C = c;
    }


    public double CalculateSquare()
    {
        return A * B * 0.5;
    }
}

