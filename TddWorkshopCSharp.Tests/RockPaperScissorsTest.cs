using System;
using Xunit;

namespace TddWorkshopCSharp.Tests;

public class RockPaperScissorsTest
{
    [Theory]
    [InlineData("Rock", "Paper", "Paper beats Rock")]
    [InlineData("Paper", "Rock", "Paper beats Rock")]
    public void Play_WhenGesturesAreRockAndPaper_ReturnsPaper(string gesture1, string gesture2, string expected)
    {
        var result = RockPaperScissors.Play(gesture1, gesture2);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("Scissors", "Paper", "Scissors beats Paper")]
    [InlineData("Paper", "Scissors", "Scissors beats Paper")]
    public void Play_WhenGesturesAreScissorsAndPaper_ReturnsScissors(string gesture1, string gesture2, string expected)
    {
        var result = RockPaperScissors.Play(gesture1, gesture2);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("Rock", "Scissors", "Rock beats Scissors")]
    [InlineData("Scissors", "Rock", "Rock beats Scissors")]
    public void Play_WhenGesturesAreRockAndScissors_ReturnsRock(string gesture1, string gesture2, string expected)
    {
        var result = RockPaperScissors.Play(gesture1, gesture2);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Play_WhenGesturesAreInvalid_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => RockPaperScissors.Play(string.Empty, string.Empty));
    }
}