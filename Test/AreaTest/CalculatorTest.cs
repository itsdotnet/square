using Square;

namespace AreaTest;

public class CalculatorTest
{
    [Theory]
    [InlineData(5)]
    [InlineData(5.5)]
    [InlineData(1516651)]
    [InlineData(125.2323)]
    public void ShouldReturnCircleArea(double radius)
    {
        double result = AreaCalculator.CircleArea(radius);
        double expectedResult = radius * radius * Math.PI;
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ShouldReturnTriangleArea()
    {
        double result = AreaCalculator.TriArea(3, 4, 5);
        Assert.Equal(6, result);
    }
    
    [Theory]
    [InlineData(4, 5, 6)]
    [InlineData(5.5, 4.2, 3.1)]
    [InlineData(3, 3, 7)]
    public void ShouldReturnTriArea(double a, double b, double c)
    {
        
        double result = AreaCalculator.TriArea(a, b, c);
        double s = (a + b + c) / 2;
        double expectedResult = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        
        if(a + b < c || a + c < b || b + c < a)
            Assert.Equal(0, result);
        else
            Assert.Equal(expectedResult, result);
    }
}