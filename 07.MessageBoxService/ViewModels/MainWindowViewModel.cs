namespace _07.MessageBoxService.ViewModels;

using EnkuViewModelLocator.Wpf;
using CommunityToolkit.Mvvm.ComponentModel;
using EnkuToolkit.UiIndependent.Services;
using CommunityToolkit.Mvvm.Input;

[ViewModel]
public partial class MainWindowViewModel : ObservableObject
{
    private readonly IMessageBoxService _messageBoxService;

    public MainWindowViewModel(IMessageBoxService messageBoxService)
    {
        this._messageBoxService = messageBoxService;
    }

    [ObservableProperty]
    private string _txt = "Hello World!";

    [RelayCommand]
    private void ShowMessageBox()
    {
        this._messageBoxService.ShowOk(this.Txt, "warning");
    }
}