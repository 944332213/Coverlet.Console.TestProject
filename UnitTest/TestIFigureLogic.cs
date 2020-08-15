namespace UnitTest
{
    using Contract;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using WebApplication;

    [TestClass, ExcludeFromCodeCoverage]
    public class TestIFigureLogic
    {
        private IServiceProvider _serviceProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            var services = new ServiceCollection();
            services.AddLogic();
            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestGetCommonGraphic()
        {
            Func<int, IEnumerable<string>> action = _serviceProvider.GetService<IFigureLogic>().GetCommonGraphic;
            {
                var result = action(4)?.ToArray();
                Assert.IsTrue(result?.Length > 1);
            }
        }
    }
}