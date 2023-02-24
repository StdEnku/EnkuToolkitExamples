namespace _10.ApplicationPropertyiesService.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnkuToolkit.UiIndependent.Services;
using EnkuViewModelLocator.Wpf;

[ViewModel]
public partial class Page2ViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    private readonly IApplicationPropertyiesService _applicationPropertyiesService;

    public Page2ViewModel(INavigationService navigationService,
                          IApplicationPropertyiesService applicationPropertyiesService)
    {
        this._navigationService = navigationService;
        this._applicationPropertyiesService = applicationPropertyiesService;
        this.myText = this._applicationPropertyiesService.Properties["MyText"] as string ?? string.Empty;
    }

    [ObservableProperty]
    private string myText;

    [RelayCommand]
    private void Clicked()
    {
        this._navigationService.GoBack();
    }
}