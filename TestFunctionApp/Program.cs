using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication(builder =>
    {
        builder.Services.Configure<JsonSerializerOptions>(options =>
        {
            options.IncludeFields = true;
        });
    })
    .Build();

host.Run();
