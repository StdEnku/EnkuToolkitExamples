namespace _00.AnimatedFrame;

using System;
using System.Windows;

public partial class MainWindow : Window
{
    private readonly Uri _baseUri = new Uri("pack://application:,,,/", UriKind.Absolute);

    public MainWindow()
    {
        InitializeComponent();
    }

    private void GoBack(object sender, RoutedEventArgs e)
    {
        this.MainFrame.GoBack();
    }

    private void GoForward(object sender, RoutedEventArgs e)
    {
        this.MainFrame.GoForward();
    }

    private void GoPage1(object sender, RoutedEventArgs e)
    {
        var nextUri = new Uri(this._baseUri, "Page1.xaml");
        this.MainFrame.Navigate(nextUri);
    }

    private void GoPage2(object sender, RoutedEventArgs e)
    {
        var nextUri = new Uri(this._baseUri, "Page2.xaml");
        this.MainFrame.Navigate(nextUri);
    }
}
