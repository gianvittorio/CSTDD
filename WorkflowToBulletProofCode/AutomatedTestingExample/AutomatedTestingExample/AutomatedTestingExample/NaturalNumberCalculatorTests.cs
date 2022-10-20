namespace AutomatedTestingExample;

using Xunit;

public class NaturalNumberCalculatorTests
{
    [Fact]
    public void SubtractMethod_Numbers_Success()
    {
        var calculator = new NaturalNumberCalculator();
        var result = calculator.Subtract(4, 3);
        
        
        Assert.Equal(1, result);
    }
}