using Splatrika.SquareLibrary.Abstractions;

namespace Splatrika.SquareLibrary;

public class Circle : IShape
{
    public double Radius { get; }


    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0");
        }
        Radius = radius;
    }


    public double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}

