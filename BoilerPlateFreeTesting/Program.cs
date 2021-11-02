using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace BoilerPlateFreeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                        .CaptureStartupErrors(true)
                        .UseSetting(WebHostDefaults.DetailedErrorsKey, "true");
                })
                .ConfigureLogging(log => log.ClearProviders())
                .UseNLog();
    }
}