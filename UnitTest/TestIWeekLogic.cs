namespace UnitTest
{
    using Contract;
    using Microsoft.AspNetCore.TestHost;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using WebApplication;

    [TestClass, ExcludeFromCodeCoverage]
    public class TestIWeekLogic
    {
        private TestServer _testServer;
        private IServiceProvider _serviceProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            _testServer = Program.CreateHostBuilder(new string[0]).ConfigureWebHost(webBuilder =>
            {
                //webBuilder.ConfigureServices(services =>
                //{
                //    services.AddLogic();
                //});
                webBuilder.UseTestServer();
            }).Start().GetTestServer();
            _serviceProvider = _testServer.Services;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _testServer.Dispose();
        }

        [TestMethod]
        public void TestGetWeeks()
        {
            Func<IEnumerable<DayOfWeek>> action = _serviceProvider.GetService<IWeekLogic>().GetWeeks;
            {
                var result = action()?.ToArray();
                Assert.IsTrue(result?.Length > 1);
            }
        }
    }
}