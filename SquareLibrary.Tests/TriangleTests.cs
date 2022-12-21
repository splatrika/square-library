using Xunit;

namespace Splatrika.SquareLibrary.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(2, 2, 2.8284271247)]
    [InlineData(3, 4, 5)]
    public void CreateWithValidEdges(double a, double b, double c)
    {
        new Triangle(a, b, c);
    }


    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(3, -1, 5.5)]
    [InlineData(3, 1, -5.5)]
    public void CreateWithInvalidEdges(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }


    [Theory]
    [InlineData(2, 2, 2.8284271247, 2)]
    [InlineData(3, 4, 5, 6)]
    [InlineData(3, 4, 2, 2.90473750966)]
    public void CalculateSquare(double a, double b, double c,
        double exceptedSquare)
    {
        var triangle = new Triangle(a, b, c);
        var square = triangle.CalculateSquare();

        Assert.Equal(exceptedSquare, square, Constants.Precision);
    }
}

