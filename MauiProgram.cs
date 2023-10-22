using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using testapp.Data;

namespace testapp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.Configuration.AddJsonFile("appsettings.json");

        var configuration = builder.Configuration;
        var connectionString = configuration.GetConnectionString("DefaultConnection");


        builder.Services
               .AddDbContext<DatabaseContext>(options => options
               .UseSqlServer(connectionString));

        builder.Services
               .AddTransient<MainPage>();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Logging.AddDebug();

        return builder.Build();
    }

    public static IServiceProvider CreateServiceProvider()
    {
        var builder = MauiApp.CreateBuilder();
        return builder.Services.BuildServiceProvider();
    }
}
