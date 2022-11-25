using Xunit;

namespace FizzBuzz.Tests;

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
}