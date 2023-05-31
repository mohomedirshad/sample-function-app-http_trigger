using Microsoft.Extensions.Hosting;
using My_first_Azure_function__Http_Trigger_;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults(builder =>
    {
        builder.UseMiddleware<ExceptionHandlerMiddleware>();
    })
    .ConfigureServices(services =>
    {
    })
    .Build();

host.Run();
