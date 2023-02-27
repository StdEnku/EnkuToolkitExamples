# ViewModelProviderExtension

![img1](./imgs/img1.png)

注意点:本サンプルではEnkuToolkit.Wpfのほかに以下のサードパーティ製ライブラリを使用しています。

- [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm)
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/8.0.0-preview.1.23110.8)

## 備考
DIコンテナからViewModelのオブジェクトを生成するためのマークアップ拡張



## クラス情報

### マークアップ拡張

名前空間 : `EnkuToolkit.Wpf.MarkupExtensions`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>xml名前空間 : `https://github.com/StdEnku/EnkuToolkit`

### Appクラスにて実装しなければならないインターフェース

インターフェース名 : `IServicesOwner`<br/>名前空間 : `EnkuToolkit.Wpf.MarkupExtensions`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>



## 使い方

まずは準備として下記のような`Microsoft.Extensions.DependencyInjection`を<br/>Appクラスで初期設定行うコードを作成してください。

App.xaml.cs

```c#
namespace MyApp;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

public partial class App : Application
{
    public App()
    {
        this.Services = ConfigureServices();
        this.InitializeComponent();
    }

    // App.Current経由でIServiceProviderを取得するためのプロパティ
    public IServiceProvider Services { get; }

    // DIコンテナへの登録用メソッド
    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        // 登録処理
        
        return services.BuildServiceProvider();
    }
}
```





次にそのAppクラスに`IServicesOwner`インターフェースを継承してください<br/>このインターフェースのメンバーはSystem.IServiceProvider型のプロパティのみです<br/>

```c#
IServiceProvider Services { get; }
```

もうすでにAppクラスにはIServiceProviderのゲッターのみを持つServicesプロパティが存在するので<br/>インターフェースを実装するコードの追加をする必要ありません。<br/>そうしたらConfigureServicesメソッド内でDIコンテナに登録したい<br/>ViewModelやViewServiceの登録処理を記してください。

App.xaml.cs

```c#
namespace MyApp;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using EnkuToolkit.Wpf.MarkupExtensions; // <-追記

public partial class App : Application, IServicesOwner // <-追記
{
    public App()
    {
        this.Services = ConfigureServices();
        this.InitializeComponent();
    }

    // App.Current経由でIServiceProviderを取得するためのプロパティ
    public IServiceProvider Services { get; }

    // DIコンテナへの登録用メソッド
    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        // 登録処理を記す。
        services.AddTransient<HogePageViewModel>();
        services.Addtransient<IHogeService, HogeService>();

        return services.BuildServiceProvider();
    }
}
```

この段階でAppクラスへの修正は終わりです。



次はView側でDIコンテナから登録されたViewModelのオブジェクトをViewのDataContextに指定します。

EnkuToolkitのxml名前空間とViewModelのxml名前空間を定義して<br/>ViewModelProviderマークアップ拡張のコンストラクタに指定したいViewModelの<br/>Typeオブジェクトを渡せばViewModelのオブジェクトをDIコンテナから取得できるので<br/>その値をDataContextに指定すれば完了です。

Page1.xaml

```xaml
<Page ~省略~
      xmlns:et="https://github.com/StdEnku/EnkuToolkit"
      xmlns:vm="clr-namespace:To.ViewModel.Path"
      DataContext="{et:ViewModelProvider vm:HogePageViewModel}">

</Page>
```

しかしこの状態ではインテリセンスが効かないので下記のように<br/>d:DataContextを指定することをお勧めします。

```c#
<Page ~省略~
      xmlns:et="https://github.com/StdEnku/EnkuToolkit"
      xmlns:vm="clr-namespace:To.ViewModel.Path"
      DataContext="{et:ViewModelProvider vm:HogePageViewModel}"
      d:DataContext="{d:DesignInstance vm:MainWindowViewModel}">

</Page>
```

