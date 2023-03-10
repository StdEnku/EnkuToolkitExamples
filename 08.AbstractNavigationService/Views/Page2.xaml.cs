namespace _08.AbstractNavigationService.Views;

using _08.AbstractNavigationService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>
/// Page2.xaml の相互作用ロジック
/// </summary>
public partial class Page2 : Page
{
    public Page2()
    {
        InitializeComponent();
        var services = App.Current.Services;
        this.DataContext = services.GetService(typeof(Page2ViewModel));
    }
}
