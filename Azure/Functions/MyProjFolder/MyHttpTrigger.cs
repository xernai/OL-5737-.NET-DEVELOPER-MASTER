using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjFolder
{
    public class MyHttpTrigger
    {
        private readonly ILogger<MyHttpTrigger> _logger;

        public MyHttpTrigger(ILogger<MyHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("MyHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }

        [Function("GetUsersHttpTrigger")]
        public async Task<IActionResult> GetUsersHttpTrigger([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var client = new HttpClient();
            var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/users");
            var responseString = await response.Content.ReadAsStringAsync();

            return (ActionResult)new OkObjectResult(responseString);
        }
    }
}
