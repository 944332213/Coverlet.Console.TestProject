# ˵��

������� <https://github.com/coverlet-coverage/coverlet/issues/922> (����ע������Ͳ���ʶ�𸲸Ƿ�Χ) ��������Ŀ

## ��ǰ����

- �ڵ�Ԫ������������ `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();` ����̬���캯��/���캯�������ᵼ�� `Implement` ��Ŀ������Ϊ0.
- �ڵ�Ԫ�������е��ã���̬���캯��/���캯��/TestInitialize���򲻻ᷢ�������Σ��μ���[TestIWeekLogic.cs](UnitTest/TestIWeekLogic.cs)��
- ��ʹ�� Visual Studio 2019 �������������������ʶ��

----

## �����ʽ��

1. ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200817171019.png)
1. ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817162652.png)
    - ������������ [coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817171153.png)

## �ֶ�����

1. Visual Studio 2019
    1. ʹ�� Visual Studio 2019 ����Ŀ `Coverlet.Console.TestProject.sln`
    1. �����˵��� "����(S) -> �������в��ԵĴ��븲����(C)"
    1. ����ʾ�� "���븲���ʽ��" �в鿴���
1. coverlet.console
    1. ���� [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. �ڵ����Ŀ���̨���ڲ鿴���
