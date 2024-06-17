using System.Diagnostics;

namespace GuessingGame;

/// <summary>
/// Guessing game engine.
/// </summary>
public readonly record struct Engine
{
    readonly int _answer;
    readonly int _min;
    readonly int _max;

    public Engine(int answer, int min, int max)
    {
        if (answer < min || answer > max)
        {
            throw new ArgumentException("answer must be between min and max.", nameof(answer));
        }

        _answer = answer;
        _min = min;
        _max = max;
    }

    public int? Parse(string input)
    {
        return int.TryParse(input, out int guess) && _min <= guess && _max >= guess 
            ? guess 
            : null;
    }

    public string Evaluate(int guess)
    {
        return guess.CompareTo(_answer) switch
        {
            -1 => "Higher",
            0 => "Correct!",
            1 => "Lower",
            _ => throw new UnreachableException()
        };
    }
}