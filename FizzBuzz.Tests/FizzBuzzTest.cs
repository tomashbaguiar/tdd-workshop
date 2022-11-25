using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(3)]
    public void Resolve_WhenInputIsMultipleOfThree_ReturnsFizz(int input)
    {
        var result = FizzBuzz.Resolve(input);
        
        Assert.Equal("Fizz", result);
    }
}