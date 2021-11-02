using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BoilerPlateFreeTesting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<TestRepository>();
            services.AddTransient<TestService>();
            
        }
        
        public void Configure(IApplicationBuilder app,
            ILogger<Startup> logger,
            IWebHostEnvironment env,
            IHostApplicationLifetime appLifetime,
            TestService service)
        {
            try
            {
                service.runService();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                appLifetime.StopApplication();
            }
        }
    }
}