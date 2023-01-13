using Forge.Logging.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace Forge.Logging.Microsoft
{

    /// <summary>ServiceCollection extension methods</summary>
    public static class ServiceCollectionExtensions
    {

        /// <summary>
        /// Registers the Forge Microsoft logging
        /// </summary>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddForgeMicrosoftLogging(this IServiceCollection services)
        {
            return services.AddSingleton<ILoggerWrapper, MSManager>();
        }

    }

}
