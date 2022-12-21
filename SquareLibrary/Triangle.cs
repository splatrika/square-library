using Splatrika.SquareLibrary.Abstractions;

namespace Splatrika.SquareLibrary;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }


    public Triangle(double a, double b, double c)
    {
        ValidateEdge(a);
        ValidateEdge(b);
        ValidateEdge(c);

        A = a;
        B = b;
        C = c;
    }


    public double CalculateSquare()
    {
        var isRight =
            Math.Round(A * A + B * B, Constants.Precision)
            == Math.Round(C * C, Constants.Precision);
        if (isRight)
        {
            return A * B * 0.5;
        }
        var p = (A + B + C) * 0.5;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }


    private void ValidateEdge(double edge)
    {
        if (edge <= 0 )
        {
            throw new ArgumentException("Edge must be greater than 0");
        }
    }
}

