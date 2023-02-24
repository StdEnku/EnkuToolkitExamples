namespace _10.ApplicationPropertyiesService.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnkuToolkit.UiIndependent.Services;
using EnkuViewModelLocator.Wpf;

[ViewModel(ViewModelAttribute.ServiceLifeTime.Singleton)]
public partial class Page1ViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    private readonly IApplicationPropertyiesService _applicationPropertyiesService;

    public Page1ViewModel(INavigationService navigationService, 
                          IApplicationPropertyiesService applicationPropertyiesService)
    {
        this._navigationService = navigationService;
        this._applicationPropertyiesService = applicationPropertyiesService;
    }

    [ObservableProperty]
    private string myText = "Hello World!";

    [RelayCommand]
    private void Clicked()
    {
        this._applicationPropertyiesService.Properties["MyText"] = this.MyText;
        this._navigationService.NavigateRootBase("Views/Page2.xaml");
    }
}