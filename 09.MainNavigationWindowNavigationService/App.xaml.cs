namespace _09.MainNavigationWindowNavigationService;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using EnkuToolkit.UiIndependent.Services;
using EnkuToolkit.Wpf.Services;
using _09.MainNavigationWindowNavigationService.ViewModels;

public partial class App : Application
{
    public App()
    {
        this.Services = ConfigureServices();
        this.InitializeComponent();
    }

    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<Page1ViewModel>();
        services.AddTransient<Page2ViewModel>();
        services.AddTransient<INavigationService, MainNavigationWindowNavigationService>();

        return services.BuildServiceProvider();
    }
}
