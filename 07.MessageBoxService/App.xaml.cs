namespace _07.MessageBoxService;

using _07.MessageBoxService.ViewModels;
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

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<IMessageBoxService, MessageBoxService>();

        return services.BuildServiceProvider();
    }
}