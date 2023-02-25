# MainNavigationWindowNavigationService

## 備考

App.Current.MainWindowがNavigationWindowの場合使用可能なViewModelから画面遷移させるためのViewService



## クラス情報

### インターフェース側

インターフェース名 : `INavigationService`<br/>名前空間 : `EnkuToolkit.UiIndependent.Services`<br/>アセンブリ : `EnkuToolkit.UiIndependent`<br/>

### 実装側

クラス名 : `MainNavigationWindowNavigationService`<br/>名前空間 : `EnkuToolkit.Wpf.Behaviors`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>



## 使い方

App.Current.MainWindowがNavigationWindow型のオブジェクトならば<br/>わざわざAbstractNavigationServiceを継承した自作クラスを作成しなくていいように<br/>ライブラリ側で用意しておきました。

DIコンテナにINavigationServiceインターフェースと<br/>MainNavigationWindowNavigationServiceクラスを<br/>登録してViewModelにてコンストラクタインジェクションを使用して<br/>使用してください。

また、インターフェース側に記されているメソッドやプロパティは<br/>[AbstractNavigationServiceのREADME](../08.AbstractNavigationService/README.md)に記されているものと同じです。
