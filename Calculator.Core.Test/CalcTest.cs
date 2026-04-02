using System;
using Xunit;

namespace Calculator.Core.Test;

public class CalcTest
{
    [Theory]
    [InlineData(1, 2)]
    [InlineData(-1, -2)]
    [InlineData(0, 2)]
    public void Div_PositiveTest(double a, double b)
    {
        var expected = a / b;
        var actual = Calc.Div(a,b);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Div_NegativeTest()
    {
        Assert.Throws<DivideByZeroException>(() =>
        {
            Calc.Div(1, 0);
        });
    }
}