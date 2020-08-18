# ˵��

������� <https://github.com/coverlet-coverage/coverlet/issues/922> (����ע������Ͳ���ʶ�𸲸Ƿ�Χ) ��������Ŀ

## ��ǰ����

- �ڵ�Ԫ������������ `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();` ����̬���캯��/���캯�������ᵼ�� `Implement` ��Ŀ������Ϊ0.
- �ڵ�Ԫ�������е��ã���̬���캯��/���캯��/TestInitialize���򲻻ᷢ��������(���ᵼ�¸���ĸ�����ʶ��ʧ�ܣ���������������ʶ������)���μ���[TestIWeekLogic.cs](UnitTest/TestIWeekLogic.cs)��
- ���������������Ϊ `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();` �����²����า����ʶ��ʧЧ
- ��ʹ�� Visual Studio 2019 �������������������ʶ��

## ����취

- ������� `HostingAbstractionsHostBuilderExtensions.Start(this IHostBuilder hostBuilder);` ��ֻ��Ҫ�������Ϊ `IHostBuilder.Build();` �� ��ʹ�� `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Build();` �滻 `Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();` �����޷����͸�����ԭ���������֪����������ң���ʤ�м�

----

## �����ʽ��

1. ���� `Implement` ���в�����ʧЧ���� 
    ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817162652.png)
1. ���ǽ�`TestIWeekLogic`ʧЧ���� 
    ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200817171153.png)
1. ������������ 
    ![coverlet.console 1.7.2](RunningResultScreenshot/coverlet.console%201.7.2_20200818144324.png)
1. ����Visual Studio 2019 �����`1`�Ķ��� 
    ![Visual Studio 2019](RunningResultScreenshot/Visual%20Studio%202019_20200817171019.png)

## �ֶ�����

1. Visual Studio 2019
    1. ʹ�� Visual Studio 2019 ����Ŀ `Coverlet.Console.TestProject.sln`
    1. �����˵��� "����(S) -> �������в��ԵĴ��븲����(C)"
    1. ����ʾ�� "���븲���ʽ��" �в鿴���
1. coverlet.console
    1. ���� [Coverlet.Console.Test.bat](RunningResultScreenshot/Coverlet.Console.Test.bat)
    2. �ڵ����Ŀ���̨���ڲ鿴���
