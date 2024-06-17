using Xunit;

namespace GuessingGame.Tests;

public class EvaluationTests
{
    Engine _engine = new (7, 1, 10);

    [Fact]
    public void ValidGuessesLowerThanAnswerSayHigher()
    {
        Assert.Equal("Higher", _engine.Evaluate(6));
    }
    
    [Fact]
    public void ValidGuessesHigherThanAnswerSayLower()
    {
        Assert.Equal("Lower", _engine.Evaluate(8));
    }
    
    [Fact]
    public void ValidGuessesEqualToAnswerSayCorrectBang()
    {
        Assert.Equal("Correct!", _engine.Evaluate(7));
    }

    [Fact(Skip = "Not implemented yet")]
    public void Guessing42IsAlwaysCorrect()
    {
    }
}