GuessingGame
===========

An implementation of a guessing game including a living specification (see `Guessing Game Specification/Guessing Game Specification.md`).

Requirements
-----------

Requires a test logger for each type of file to generate (only need one really). 

Choose from: JunitXml.TestLogger, NunitXml.TestLogger, XunitXml.TestLogger or Microsoft.NET.Test.Sdk. 

Then run tests, using `--logger` to specify your logger. 

```shell
dotnet test --results-directory=./testresults/ --logger "trx;LogFileName=FreezeTester.trx" --logger:"xunit;LogFilePath=./testresults/xunit_test_result.xml" --logger:"nunit;LogFilePath=./testresults/nunit-test-result.xml" --logger:"junit;LogFilePath=./testresults/junit-test-result.xml"
```