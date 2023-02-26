# AbstractNavigationService

注意点:本サンプルではEnkuToolkit.Wpfのほかに以下のサードパーティ製ライブラリを使用しています。

- [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm)
- [EnkuViewModelLocator.Wpf](https://www.nuget.org/packages/EnkuViewModelLocator.Wpf)
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/8.0.0-preview.1.23110.8)

## 備考

MainWindow内のFrameなどをViewModelから画面遷移させるためのViewService



## クラス情報

### インターフェース側

インターフェース名 : `INavigationService`<br/>名前空間 : `EnkuToolkit.UiIndependent.Services`<br/>アセンブリ : `EnkuToolkit.UiIndependent`<br/>

### 実装側

抽象クラス名 : `AbstractNavigationService`<br/>名前空間 : `EnkuToolkit.Wpf.Behaviors`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>



## 使い方

DIコンテナにINavigationServiceインターフェースと<br/>AbstractNavigationService抽象クラスを継承したクラスを<br/>登録してViewModelにてコンストラクタインジェクションを使用して<br/>使用することを想定しています。



AbstractNavigationServiceには下記のabstractプロパティが定義されており、

```c#
protected abstract NavigationService TargetNavigationService { get; }
```

それをオーバーロードします。<br/>返す値は画面遷移で使用するFrameやNavigationWindowの<br/>NavigationServiceプロパティを返すように記述してください。

### INavigationServceインターフェースに定義されているメソッドやプロパティ

#### NavigateRootBaseメソッド

```c#
bool NavigateRootBase(string uriStr, object? extraData = null);
```

プロジェクトのルートフォルダをベースURIとして遷移先のURIを指定できる画面遷移用メソッド

戻り値 : 画面遷移がキャンセルされたらfalse、キャンセルされなければtrueを返す<br/>uriStr : 遷移先ページへの相対URI<br/>extraData : 遷移先に渡したいデータ。[NavigatedParamSendBehavior](https://github.com/StdEnku/EnkuToolkitExamples/tree/main/11.NavigatedParamSendBehavior)を使用して遷移先のViewModelで受け取ることを想定している。



#### Navigateメソッド

```c#
bool Navigate(Uri uri, object? extraData = null);
```

遷移先のURIを指定して画面遷移を行うためのメソッド

戻り値 : 画面遷移がキャンセルされたらfalse、キャンセルされなければtrueを返す<br/>uri : 遷移先ページへURI<br/>extraData : 遷移先に渡したいデータ。[NavigatedParamSendBehavior](https://github.com/StdEnku/EnkuToolkitExamples/tree/main/11.NavigatedParamSendBehavior)を使用して遷移先のViewModelで受け取ることを想定している。



#### GoForwardメソッド

```c#
void GoForward();
```

履歴を元に表示されているページを進めるためのメソッド



#### GoBackメソッド

```c#
void GoBack();
```

履歴を元に表示されているページを戻すためのメソッド



#### Refreshメソッド

```c#
void Refresh();
```

表示されているページの再読み込みを行うためのメソッド



#### RempveBackEntryメソッド

```c#
void RemoveBackEntry();
```

履歴から前回表示されていたページを削除するためのメソッド



#### StopLoadengメソッド

```c#
void StopLoading();
```

画面遷移を中断するためのメソッド



#### removeAllHistoryメソッド

```c#
void RemoveAllHistory();
```

ナビゲーション履歴をすべて削除するためのメソッド



#### CanGoBackプロパティ

```c#
bool CanGoBack { get; }
```

画面遷移対象のFrameやNavigationWindowでGoBackメソッドが実行可能かを表すプロパティ



#### CanGoForwardプロパティ

```c#
bool CanGoForward { get; }
```

画面遷移対象のFrameやNavigationWindowでGoForwardメソッドが実行可能かを表すプロパティ
