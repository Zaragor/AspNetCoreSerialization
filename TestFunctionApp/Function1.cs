using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace TestFunctionApp
{
    public class Function1
    {
        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req)
        {
            await Task.Delay(10);
            return new OkObjectResult(new MyInfo() { ExampleBool = true, ExampleString = "Hello World" });
        }
    }

    public class MyInfo
    {
        public string ExampleString;

        public bool ExampleBool;
    }
}
