﻿namespace _11.NavigatedParamSendBehavior;

using EnkuToolkit.UiIndependent.Services;
using EnkuToolkit.Wpf.Services;
using EnkuViewModelLocator.Wpf;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Windows;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application, IDiApplication
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

        var assembly = Assembly.GetExecutingAssembly();
        var vmWithLifeTime = SearchViewModelService.FromAssembly(assembly);
        foreach (var i in vmWithLifeTime)
        {
            if (i.LifeTime == ViewModelAttribute.ServiceLifeTime.Transient)
                services.AddTransient(i.ViewModelType);
            else
                services.AddSingleton(i.ViewModelType);
        }

        services.AddTransient<INavigationService, MainNavigationWindowNavigationService>();

        return services.BuildServiceProvider();
    }
}
