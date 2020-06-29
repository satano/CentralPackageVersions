using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Demo.AzFunc
{
    public class DemoFunction
    {
        [FunctionName(nameof(DemoFunction))]
        public async Task Run([TimerTrigger("%Schedule%")] TimerInfo myTimer, ILogger log)
        {
            await Task.CompletedTask;
        }
    }
}
