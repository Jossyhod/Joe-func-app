using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class JoeTrigger
    {
        private readonly ILogger<JoeTrigger> _logger;

        public JoeTrigger(ILogger<JoeTrigger> logger)
        {
            _logger = logger;
        }

        [Function("JoeTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions by Joseph!");
        }
    }
}
