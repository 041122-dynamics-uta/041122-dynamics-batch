using ClassesDemo;
using Xunit;

namespace Tests.TddDemo;

public class UnitTest1
{
    [Fact]// The FACT annotation states to Xunit that this is a single test.
    public void HumanParameterlessConstructorCreatesHumanWithDefaultValues()
    {
        // Step 1. Arrange
        Human h = new Human();

        // Step 2. Act
        // this step is unneeded for this test 
        // because the constructor does the actions we would have done.

        // Step 3. Assert
        // .Equals() tests whether the two instances are 'considered' equal.
        // "Equal()" means the same memory location
        // .Equals() is like saying 1 == 1 even if the 2 instances of 1 are 
        // held in different spots in memory.
        Assert.Equal("origami", h.TypeOfPlane);
    }

    [Fact]
    public void EqualComparesequalnumbersOfDifferentTypes()
    {
        // Step 1, Arrange 
        double d1 = 123.0;
        long l1 = 123;

        //Step 2. Act unneeded

        // Step3. Assert
        Assert.Equal(d1, l1);
        //Assert.Equal(expected, actual);
    }

    [Fact]
    public void EqualComparesDefaultHumans()
    {
        //Arrange
        Human h1 = new Human();
        Human h2 = new Human();
        Human h3 = h1;// give the HEAP memory location to the other Human reference variable

        // Act


        //Assert
        Assert.Equal(h1, h3);//NOW they are equal!
    }

    [Fact]
    public void AnimalAgeSetsAgeCorrectly()
    {
        //arrange
        Human h1 = new Human("Jerry", "McGuire", "Green");

        //act
        h1.AnimalAge(40);

        //assert
        Assert.Equal(40, h1.AnimalAge());
    }


    [Theory]
    [InlineData(1)]
    [InlineData(1000)]
    [InlineData(543)]
    [InlineData(-20)]
    public void AnimalAgeSetsAgesCorrectly(int x)
    {
        //arrange
        Human h1 = new Human("Jerry", "McGuire", "Green");

        //act
        Assert.Equal(0, h1.AnimalAge());
        h1.AnimalAge(x);


        //assert
        Assert.Equal(x, h1.AnimalAge());
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(1000, false)]
    [InlineData(543, false)]
    [InlineData(-20, false)]
    [InlineData(42, true)]
    public void TryAnimalAgeReturnsTrueFalse(int x, bool b)
    {
        //arrange
        Human h1 = new Human("Jerry", "McGuire", "Green");

        //act
        Assert.Equal(0, h1.AnimalAge());
        h1.AnimalAge(x);
        bool result = h1.TryAnimalAge(x);

        //assert
        if (!b)
        {
            Assert.False(result);
        }
        else
            Assert.True(result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(11000, false)]
    [InlineData(543.3, false)]
    [InlineData(-200, false)]
    [InlineData(24, true)]
    public void TryAnimalAgeReturnsTrueFalse1(int x, bool b)
    {
        //arrange
        Human h1 = new Human("Jerry", "McGuire", "Green");

        //act
        Assert.Equal(0, h1.AnimalAge());
        h1.AnimalAge(x);
        bool result = h1.TryAnimalAge(x);

        //assert
        switch (b)
        {
            case false:
                Assert.False(result);
                break;
            case true:
                Assert.True(result);
                break;
        }



    }
}// EoC