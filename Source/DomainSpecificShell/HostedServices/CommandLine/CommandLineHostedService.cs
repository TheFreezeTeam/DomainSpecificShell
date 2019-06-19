namespace DomainSpecificShell.HostedServices
{
  using Microsoft.Extensions.Hosting;
  using Microsoft.Extensions.Logging;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading;
  using System.Threading.Tasks;

  internal class CommandLineHostedService : BackgroundService
  {
    private readonly ILogger<CommandLineHostedService> Logger;
    internal CommandLineHostedService(ILogger<CommandLineHostedService> aLogger)
    {
      Logger = aLogger;
    }

    protected override Task ExecuteAsync(CancellationToken aCancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
