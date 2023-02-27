﻿namespace _12.ViewModelProviderExtension;

using _12.ViewModelProviderExtension.ViewModels;
using EnkuToolkit.UiIndependent.ApplicationInterfaces;
using EnkuToolkit.UiIndependent.Services;
using EnkuToolkit.Wpf.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

public partial class App : Application, IServicesOwner
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
        services.AddTransient<INavigationService, MainNavigationWindowNavigationService>();

        return services.BuildServiceProvider();
    }
}
