using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Samples_Book_Building_WebApp_with_Blazor.Services;
using Samples_Book_Building_WebApp_with_Blazor.Services.Implementations;

namespace test_Blazor_ebook1
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var config = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                     .AddCommandLine(args)
                                     //.AddEnvironmentVariables(prefix: "MyCustomPrefix_");
                                     .Build();
                    var baseUrl = config.GetSection("BlazorBaseUrl");
                    
                    webBuilder
                        .UseStartup<Startup>()
                        .UseUrls(baseUrl.Value);
                })
                .ConfigureServices((hostBuilderContext, services) => {
                    services.AddHttpClient<IAuthorService, AuthorService>(client =>
                    {
                        client.BaseAddress = new Uri("https://localhost:5001");
                    }); 
                });
    }
}
