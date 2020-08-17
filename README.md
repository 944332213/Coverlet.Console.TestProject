# Explain

This is a recurring project for <https://github.com/coverlet-coverage/coverlet/issues/922> (The type of dependency injection does not recognize coverage)

## The current conclusion

- Calling 'Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();' (static constructor/constructor) from the unit test class base class results in 'Implement' project coverage of 0.
- Calling (static constructor/constructor /TestInitialize) from the unit test class does not occur (see: [TestIWeekLogic.cs](UnitTest/TestIWeekLogic.cs))
- If you are using Visual Studio 2019, all of the above can be identified normally

----

## Coverage result

1. ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200815165800.png)
1. ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817162652.png)
    - This is the normal case of [coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200815165842.png)

## Manual operation

1. Visual Studio 2019
    1. Open project `Coverlet.Console.TestProject.sln` using Visual Studio 2019
    1. Top menu bar "Test(S) -> Analyze code coverage for all tests(C)"
    1. See the results in "Code coverage Results" displayed
1. coverlet.console
    1. run [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. View the results in the console window that pops up

## Remark

- This document is a translation version, original text see: [README_zh-cn](README_zh-cn.md)
