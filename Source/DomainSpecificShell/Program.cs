namespace DomainSpecificShell
{
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.Hosting;

  internal class Program
  {
    internal static IHostBuilder CreateHostBuilder(string[] aArgumentArray) =>
    Host.CreateDefaultBuilder(aArgumentArray)
      .ConfigureServices((aHostBuilderContext, aServiceCollection) =>
        aServiceCollection.AddHostedService<Worker>());

    internal static void Main(string[] aArgumentArray) =>
      CreateHostBuilder(aArgumentArray).Build().Run();
  }
}