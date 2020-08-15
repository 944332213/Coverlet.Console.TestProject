# Explain

This is a recurring project for <https://github.com/coverlet-coverage/coverlet/issues/922> (The type of dependency injection does not recognize coverage)

## The current conclusion

I try to be used in the project I encounter the same project, and streamline way of coding, the project shows coverlet. The console is completely normal, but in my project (it is very large and can't open) still exist (similar to the project of [Implement](Implement) coverlet. The console indicating its coverage to 0), I am actively looking for differences and try to repeat the process.

----

## Coverage result

1. ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200815165800.png)
1. ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200815165842.png)

## Manual operation

1. Visual Studio 2019
    1. Open project `Coverlet.Console.TestProject.sln` using Visual Studio 2019
    1. Top menu bar "Test(S) -> Analyze code coverage for all tests(C)"
    1. See the results in "Code coverage Results" displayed
1. coverlet.console
    1. run [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. View the results in the console window that pops up
