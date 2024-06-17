using GuessingGame;

var (min, max) = (1, 10);
var engine = new Engine(Random.Shared.Next(min, max), min, max);
var input = "";

Console.WriteLine($"""
                   ********************************************
                   *       Welcome to the guessing game       *
                   ********************************************

                   Guess a number between {min} and {max}...
                   """);


input = Prompt();

while (input != "exit")
{
    var maybeGuess = engine.Parse(input);
    if (maybeGuess is { } guess)
    {
        Console.WriteLine(engine.Evaluate(guess));
    }
    else
    {
        Console.WriteLine($"Try entering a number between {min} and {max}, like 3");
    }

    input = Prompt();
}

string Prompt()
{
    Console.Write("> ");
    return Console.ReadLine() ?? "";
}
