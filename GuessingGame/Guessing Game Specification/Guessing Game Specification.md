The system should prompt the user to guess a number that has been randomly generated. It should provide feedback on their guesses until they guess the correct number.

## User Input

The computer chooses a number, within a range (`[1,10]`) and prompts the user to guess the number. 

### Rules:

* ::The user must enter a valid, whole number::{grep='WholeNumbersInRangeAreValid,NotWholeNumbersAreInvalid'}
* ::The user must enter a number that is greater than or equal to the minimum value (`1`) and less than or equal to the maximum value (`10`)::{grep='WholeNumbersOutOfRangeAreInvalid'}

## Evaluation

The computer then evaluates the user's guess and provides feedback.

### Rules:

* ::If the user's guess is equal to the answer then the feedback is `Correct!`::{grep='ValidGuessesEqualToAnswerSayCorrectBang'}
* ::If the user's guess is lower than the answer then the feedback is `Higher`::{grep='ValidGuessesLowerThanAnswerSayHigher'}
* ::If the user's guess is higher than the answer then the feedback is `Lower`::{grep='ValidGuessesHigherThanAnswerSayLower'}
* ::Guessing `42` is always correct::{grep='Guessing42IsAlwaysCorrect'}