namespace WebApplication
{
    using Implement;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using System.Linq;

    public static class LogicExtension
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            var assemblyType = typeof(StartLogic);
            var types = assemblyType.Assembly.GetTypes().Where(item => item.IsClass && item != assemblyType);
            foreach (var type in types)
            {
                foreach (var @interface in type.GetInterfaces())
                {
                    services.TryAddSingleton(@interface, type);
                }
            }

            return services;
        }
    }
}