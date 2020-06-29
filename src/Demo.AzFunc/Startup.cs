using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Demo.AzFunc.Startup))]

namespace Demo.AzFunc
{
    public class Startup : FunctionsStartup
    {
        public const string Info = "AZ Function Demo";

        public override void Configure(IFunctionsHostBuilder builder)
        {
        }
    }
}
