# 说明

这是针对 <https://github.com/coverlet-coverage/coverlet/issues/922> (依赖注入的类型不能识别覆盖范围) 的重现项目

## 当前结论

- 在单元测试类基类调用 `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();` （静态构造函数/构造函数）均会导致 `Implement` 项目覆盖率为0.
- 在单元测试类中调用（静态构造函数/构造函数/TestInitialize）则不会发生此情形（参见：[TestIWeekLogic.cs](UnitTest/TestIWeekLogic.cs)）
- 若使用 Visual Studio 2019 ，则以上情况均能正常识别

----

## 覆盖率结果

1. ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200817171019.png)
1. ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817162652.png)
    - 这是正常情形 [coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817171153.png)

## 手动运行

1. Visual Studio 2019
    1. 使用 Visual Studio 2019 打开项目 `Coverlet.Console.TestProject.sln`
    1. 顶部菜单栏 "测试(S) -> 分析所有测试的代码覆盖率(C)"
    1. 在显示的 "代码覆盖率结果" 中查看结果
1. coverlet.console
    1. 运行 [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. 在弹出的控制台窗口查看结果
