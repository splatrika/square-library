using Xunit;

namespace Splatrika.SquareLibrary.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0.1)]
    [InlineData(100)]
    public void CreateWithValidRadius(double radius)
    {
        new Circle(radius);
    }


    [Theory]
    [InlineData(0)]
    [InlineData(-12)]
    public void CreateWithInvalidRadius(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }


    [Theory]
    [InlineData(2, 12.56637)]
    [InlineData(4, 50.26548)]
    public void CalculateSquare(double radius, double exceptedSquare)
    {
        var circle = new Circle(radius);
        var square = circle.CalculateSquare();

        Assert.Equal(exceptedSquare, square, 5);
    }
}

