using DIDemoApp;
using DIDemoApp.App;
using DIDemoApp.Domain;
using DIDemoApp.Models;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        var businessLogic = host.Services.GetRequiredService<BusinessLogic>();
        IncomingRequest incomingRequest = new()
        {
            Values = new() { 1, 4, 6, 9, 10, 22, 33, 7, 3, 3 }
        };

        var sumResult = businessLogic.AddHighestValueToLowestValue(incomingRequest);
        var differenceResult = businessLogic.SubtractLowestValueFromHighestValue(incomingRequest);

        Console.WriteLine($"Sum Result : {sumResult}");
        Console.WriteLine($"Difference Result : {differenceResult}");

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<IMathService, MathService>(); // Single Instance
                services.AddTransient<BusinessLogic>(); // Created each time, when needed
            });
}