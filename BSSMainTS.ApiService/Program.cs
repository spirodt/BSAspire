using BSSMainTS.ApiService.Common;
using BSSMainTS.ApiService.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;
internal class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = appBuilder(args);
        CreateAndStartApp(builder);
    }
    private static WebApplicationBuilder appBuilder(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Caching
        builder.Services.AddOutputCache(opt =>
        {
            opt.DefaultExpirationTimeSpan = TimeSpan.FromMinutes(5);
            opt.AddPolicy("viewArtikli", builder => builder.Expire(TimeSpan.FromHours(10)));
        });

        // Add service defaults & Aspire components.
        builder.AddServiceDefaults();


        //SQL Connection string
        builder.Services.AddDbContext<BSSMainTSApiServiceContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("BSSMainTSApiServiceContext") ?? throw new InvalidOperationException("Connection string 'BSSMainTSApiServiceContext' not found."),
                sqlOptions => sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5, // Maximum number of retry attempts
                    maxRetryDelay: TimeSpan.FromSeconds(30), // Maximum delay between retries
                    errorNumbersToAdd: null // Additional SQL error numbers to consider transient
                )
            )
        );

        //Controllers
        builder.Services
            .AddControllers(o => o.Conventions.Add(new GenericCrudControllerRouteConvention()))
            .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new CrudControllerFeatureProvider());
                });


        builder.Services.AddEndpointsApiExplorer();

        //Helpers
        builder.Services.AddSwaggerGen(options =>
        {
            options.CustomSchemaIds(type => type.FullName);
        });
        // Add services to the container.
        builder.Services.AddProblemDetails();
        //Add RateLimiter to the services container.

        builder.Services.AddRateLimiter(static options =>
        {
            options.AddPolicy<string>("fixed", httpContext =>
            {
                var remoteIpAddress = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                return RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: remoteIpAddress,
                    factory: _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 10,
                        Window = TimeSpan.FromMinutes(1)
                    });
            });
        });

        return builder;
    }

    private static void CreateAndStartApp(WebApplicationBuilder builder)
    {
        //APP
        var app = builder.Build();
        app.UseRateLimiter();
        if (app.Environment.IsDevelopment())
        {
            app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
        string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)));

            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseOutputCache();
        // Configure the HTTP request pipeline.

        app.MapControllers();
        app.UseExceptionHandler();
        app.MapDefaultEndpoints();

        app.Run();
    }

}