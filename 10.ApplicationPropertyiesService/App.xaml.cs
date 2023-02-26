namespace _10.ApplicationPropertyiesService;

using _10.ApplicationPropertyiesService.ViewModels;
using EnkuToolkit.UiIndependent.Services;
using EnkuToolkit.Wpf.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Windows;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
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

        services.AddSingleton<Page1ViewModel>();
        services.AddTransient<Page2ViewModel>();
        services.AddTransient<INavigationService, MainNavigationWindowNavigationService>();
        services.AddTransient<IApplicationPropertyiesService, ApplicationPropertyiesService>();

        return services.BuildServiceProvider();
    }
}
