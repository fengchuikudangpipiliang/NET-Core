using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
#pragma warning disable CRR0029
namespace NET_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddLogging(e => {
                e.AddConsole();
                e.AddEventLog();
                e.AddNLog();
                e.SetMinimumLevel(LogLevel.Warning);
            });
            services.AddScoped<Test>();

            using(var sp = services.BuildServiceProvider())
            {
                Test test = sp.GetRequiredService<Test>();
                test.Log();
            }
        }
    }

   
}
