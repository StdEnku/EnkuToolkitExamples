# ApplicationPropertyiesService

注意点:本サンプルではEnkuToolkit.Wpfのほかに以下のサードパーティ製ライブラリを使用しています。

- [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm)
- [EnkuViewModelLocator.Wpf](https://www.nuget.org/packages/EnkuViewModelLocator.Wpf)
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/8.0.0-preview.1.23110.8)

## 備考

ViewModelからApplication.Propertyisプロパティを操作可能にするためのViewService



## クラス情報

### インターフェース側

インターフェース名 : `IApplicationPropertyiesService`<br/>名前空間 : `EnkuToolkit.UiIndependent.Services`<br/>アセンブリ : `EnkuToolkit.UiIndependent`<br/>

### 実装側

クラス名 : `ApplicationPropertyiesService`<br/>名前空間 : `EnkuToolkit.Wpf.Behaviors`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>



## 使い方

DIコンテナにIApplicationPropertyiesServiceインターフェースと<br/>ApplicationPropertyiesServiceクラスを<br/>登録してViewModelにてコンストラクタインジェクションを使用して<br/>使用することを想定しています。

現在IApplicationPropertyiesServiceにて定義されているプロパティは<br/>App.Propertiesを返すIDictionary型のPropertiesプロパティのみです。
