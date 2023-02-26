namespace _09.MainNavigationWindowNavigationService.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnkuToolkit.UiIndependent.Services;

public partial class Page2ViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    public Page2ViewModel(INavigationService navigationService)
    {
        this._navigationService = navigationService;
    }

    [RelayCommand]
    private void Clicked()
    {
        this._navigationService.GoBack();
    }
}