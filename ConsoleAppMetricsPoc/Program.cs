// See https://aka.ms/new-console-template for more information
using MetricsNetStandard20;
using MetrixNetStandard21;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<ExampleHostedService>();
        services.AddSingleton<IMetric, Metric>();
    })
    .Build();

host.Run();