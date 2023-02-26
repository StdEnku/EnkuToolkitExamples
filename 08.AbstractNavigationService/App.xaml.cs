namespace _08.AbstractNavigationService;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using EnkuToolkit.UiIndependent.Services;
using _08.AbstractNavigationService.Services;
using _08.AbstractNavigationService.ViewModels;

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

        services.AddTransient<Page1ViewModel>();
        services.AddTransient<Page2ViewModel>();
        services.AddTransient<INavigationService, MainFrameNavigationService>();

        return services.BuildServiceProvider();
    }
}