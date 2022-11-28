using Xunit;

namespace TddWorkshopCSharp.Tests;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Resolve_WhenInputIsMultipleOfThree_ReturnsFizz(int input)
    {
        var result = FizzBuzz.Resolve(input);
        
        Assert.Equal("Fizz", result);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    public void Resolve_WhenInputIsMultipleOfFive_ReturnsBuzz(int input)
    {
        var result = FizzBuzz.Resolve(input);
        
        Assert.Equal("Buzz", result);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(60)]
    public void Resolve_WhenInputIsMultipleOfFiveAndThree_ReturnsFizzBuzz(int input)
    {
        var result = FizzBuzz.Resolve(input);
        
        Assert.Equal("FizzBuzz", result);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(11)]
    public void Resolve_WhenInputIsNotMultipleOfFiveOrThree_ReturnsInput(int input)
    {
        var result = FizzBuzz.Resolve(input);
        
        Assert.Equal(input.ToString(), result);
    }
}