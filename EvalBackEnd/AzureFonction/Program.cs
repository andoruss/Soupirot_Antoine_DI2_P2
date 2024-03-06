using DAL;
using IDAL;
using IService;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        
        services.AddDbContext<AzureDbContext>(options =>
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EvalDI2P2;Trusted_Connection=True;");
        });

        services.AddScoped<IEventDAL, EventDAL>();
        services.AddScoped<IEventService, EventService>();
    })
    .Build();

host.Run();
