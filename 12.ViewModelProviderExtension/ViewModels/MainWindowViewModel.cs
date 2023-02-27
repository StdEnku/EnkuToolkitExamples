namespace _12.ViewModelProviderExtension.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _fromViewModelText = "From ViewModel Text!!!";
}