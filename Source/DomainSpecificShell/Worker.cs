namespace DomainSpecificShell
{
  using Microsoft.Extensions.Hosting;
  using Microsoft.Extensions.Logging;
  using System;
  using System.Threading;
  using System.Threading.Tasks;

  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> Logger;

    public Worker(ILogger<Worker> aLogger)
    {
      Logger = aLogger;
    }

    protected override async Task ExecuteAsync(CancellationToken aCancellationToken)
    {
      while (!aCancellationToken.IsCancellationRequested)
      {
        Logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        await Task.Delay(1000, aCancellationToken);
      }
    }
  }
}