namespace _08.AbstractNavigationService.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnkuToolkit.UiIndependent.Services;

public partial class Page1ViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    public Page1ViewModel(INavigationService navigationService)
    {
        this._navigationService = navigationService;
    }

    [RelayCommand]
    private void Clicked()
    {
        this._navigationService.NavigateRootBase("Views/Page2.xaml");
    }
}