using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime;

[assembly: FunctionsStartup(typeof(memoryLeakFunction4.Startup))]

namespace memoryLeakFunction4
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            GCSettings.LatencyMode = GCLatencyMode.LowLatency;
        }
    }
}