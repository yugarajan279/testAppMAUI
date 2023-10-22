namespace testapp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        var serviceProvider = MauiProgram.CreateServiceProvider();

        // Get MainPage instance with dependencies resolved from DI
        MainPage = serviceProvider.GetRequiredService<MainPage>();
    }
}
