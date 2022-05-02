using CalculatorSolidDemo;
using Xunit;

namespace Test.CalculatorSolidDemo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        ICalculator mySG = new ScreamingGoat();
        MyCalcClass mcc = new MyCalcClass(mySG);

        // act
        double? result = mcc.DivideSomeNumbers(10, 2);

        //Assret

        Assert.Equal(100, result);


    }
}