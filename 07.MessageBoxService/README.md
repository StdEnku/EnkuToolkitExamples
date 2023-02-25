# MessageBoxService

![img1](./imgs/img1.png)

## 備考

メッセージボックスの操作をViewModelから行えるようにするためのViewServce



## クラス情報

### インターフェース側

インターフェース名 : `IMessageBoxService`<br/>名前空間 : `EnkuToolkit.UiIndependent.Services`<br/>アセンブリ : `EnkuToolkit.UiIndependent`<br/>

### 実装側

クラス名 : `MessageBoxService`<br/>名前空間 : `EnkuToolkit.Wpf.Behaviors`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>



## 使い方

DIコンテナにIMessageBoxServiceインターフェースとMessageBoxServiceクラスを<br/>登録してViewModelにてコンストラクタインジェクションを使用して<br/>使用することを想定しています。

現在IMessageBoxServiceにて定義されているメソッドは<br/>選択肢のないOKボタンのみのメッセージボックスを表示するためのメソッドである

> void ShowOk(string message, string? title = null);

と

> bool ShowYesNo(string message, string? title = null);

です。

引数のmessageは表示されるメッセージの文字列を指定して、<br/>titleはタイトルとして表示したい文字列を指定してください。

また、ShowYesNoメソッドの戻り値は<br/>ユーザーがYesボタンを押したらtrueを返し、<br/>Noを押したらfalseを返します。



