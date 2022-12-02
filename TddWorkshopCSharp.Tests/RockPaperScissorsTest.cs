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
    
    [Theory]
    [InlineData("Scissors", "Scissors", "Draw")]
    [InlineData("Rock", "Rock", "Draw")]
    [InlineData("Paper", "Paper", "Draw")]
    public void Play_WhenGesturesAreTheSame_ReturnsDraw(string gesture1, string gesture2, string expected)
    {
        var result = RockPaperScissors.Play(gesture1, gesture2);
        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("something-1", "something-2")]
    [InlineData("", "")]
    [InlineData(null, null)]
    public void Play_WhenGesturesAreInvalid_ThrowsArgumentOutOfRangeException(string gesture1, string gesture2)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => RockPaperScissors.Play(gesture1, gesture2));
    }
}