namespace UnitTest
{
    using Microsoft.Extensions.Hosting;
    using WebApplication;

    public abstract class BasicUnitTest
    {
        static BasicUnitTest()
        {
            //Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();
            //Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder =>
            //{
            //    //webBuilder.ConfigureServices(services =>
            //    //{
            //    //    services.AddLogic();
            //    //});
            //    webBuilder.UseTestServer();
            //}).Start().GetTestServer();
        }

        protected BasicUnitTest()
        {
            Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder => { }).Start();
        }
    }
}