namespace _12.ViewModelProviderExtension;

using _12.ViewModelProviderExtension.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using EnkuToolkit.Wpf.MarkupExtensions;

public partial class App : Application, IServicesOwner
{
    public App()
    {
        this.Services = ConfigureServices();
        this.InitializeComponent();
    }

    public IServiceProvider Services { get; }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainWindowViewModel>();

        return services.BuildServiceProvider();
    }
}
