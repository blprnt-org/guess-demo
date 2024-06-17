using Xunit;

namespace GuessingGame.Tests;

public class UserInputTests
{
    Engine _engine = new Engine(7, 1, 10);
    
    [Fact]
    public void WholeNumbersInRangeAreValid()
    {
        foreach (var i in Enumerable.Range(1, 10))
        {
            Assert.NotNull(_engine.Parse(i.ToString()));
        }
    }
    
    [Theory]
    [InlineData("")]
    [InlineData("3.141592")]
    [InlineData("cat in hat")]
    public void NotWholeNumbersAreInvalid(string input)
    {
        Assert.Null(_engine.Parse(input));
    }
    
    [Theory]
    [InlineData("-5")]
    [InlineData("0")]
    [InlineData("1729")]
    public void WholeNumbersOutOfRangeAreInvalid(string input)
    {
        Assert.Null(_engine.Parse(input));
    }
}