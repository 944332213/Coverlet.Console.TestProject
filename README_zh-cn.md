# 说明

这是针对 <https://github.com/coverlet-coverage/coverlet/issues/922> (依赖注入的类型不能识别覆盖范围) 的重现项目

## 当前结论

在该项目中我尽量采用了我遭遇项目相同并精简的方式编码，该项目显示 coverlet.console 完全正常，但在我遭遇的项目（它很庞大且不能公开）中仍然存在（类似该项目中 [Implement](Implement) coverlet.console 指示它的覆盖率为 0），我正在积极的寻找差异并试图重现这个过程。

----

## 覆盖率结果

1. ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200815165800.png)
1. ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200815165842.png)

## 手动运行

1. Visual Studio 2019
    1. 使用 Visual Studio 2019 打开项目 `Coverlet.Console.TestProject.sln`
    1. 顶部菜单栏 "测试(S) -> 分析所有测试的代码覆盖率(C)"
    1. 在显示的 "代码覆盖率结果" 中查看结果
1. coverlet.console
    1. 运行 [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. 在弹出的控制台窗口查看结果
