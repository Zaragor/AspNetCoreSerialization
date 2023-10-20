using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net;

namespace DefaultFunctionApp
{
    public class Function1
    {
        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {

            var response = req.CreateResponse(HttpStatusCode.OK);

            response.WriteAsJsonAsync(new MyInfo() { ExampleBool = true, ExampleString = "Hello World" });

            return response;
        }
    }

    public class MyInfo
    {
        public string ExampleString;

        public bool ExampleBool;
    }
}
