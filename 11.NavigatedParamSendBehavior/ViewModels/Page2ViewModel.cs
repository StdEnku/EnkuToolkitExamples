namespace _11.NavigatedParamSendBehavior.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnkuToolkit.UiIndependent.Services;
using EnkuToolkit.UiIndependent.ViewModelInterfaces;

public partial class Page2ViewModel : ObservableObject, INavigatedParamReceive
{
    private readonly INavigationService _navigationService;

    public Page2ViewModel(INavigationService navigationService)
    {
        this._navigationService = navigationService;
    }

    [ObservableProperty]
    private string myText = string.Empty;

    public void Navigated(object extraData)
    {
        this.MyText = (string)extraData;
    }

    [RelayCommand]
    private void Clicked()
    {
        this._navigationService.GoBack();
    }
}