// See https://aka.ms/new-console-template for more information
using MetricsNetStandard20;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetStandard20Lib;

public sealed class ExampleHostedService : IHostedService
{
    private readonly ILogger _logger;
    IMetric _metric;

    public ExampleHostedService(
        ILogger<ExampleHostedService> logger,
        IHostApplicationLifetime appLifetime,
        IMetric metric)
    {
        _logger = logger;
        _metric = metric;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("1. StartAsync has been called.");

        var tracker = new MetricTracker();

        Console.WriteLine("Let's pretent we have a nice way to inject the propery, to be researched");

        await tracker.InitAsync(new MetricTrackerConfig() { metric = _metric });

        await tracker.Track();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("4. StopAsync has been called.");

        return Task.CompletedTask;
    }
}