namespace _08.AbstractNavigationService.Services;

using _08.AbstractNavigationService.Views;
using EnkuToolkit.Wpf.Services;
using System.Windows.Navigation;

public class MainFrameNavigationService : AbstractNavigationService
{
    protected override NavigationService TargetNavigationService
    {
        get
        {
            var window = (MainWindow)App.Current.MainWindow;
            var frame = window.MainFrame;
            return frame.NavigationService;
        }
    }
}