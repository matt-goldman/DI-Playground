using Microsoft.Extensions.DependencyInjection;

namespace DI_Playground.CustomResolver
{
    public static class StartupExtensions
    {
        public static void UseResolver(this IServiceCollection sc)
        {
            var sp = sc.BuildServiceProvider();
            Resolver.RegisterServiceProvider(sp);
        }
    }
}
