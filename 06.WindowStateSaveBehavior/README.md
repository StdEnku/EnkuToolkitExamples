# WindowStateSaveBehavior

## 備考

Windowに添付すると終了時に現在の位置、サイズ、WidnowStateプロパティを保存して、<br/>次回起動時に以前の状態を復元させるためのビヘイビア。



## クラス情報

名前空間 : `EnkuToolkit.Wpf.Behaviors`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>xml名前空間 : `https://github.com/StdEnku/EnkuToolkit`



## 使い方

```xaml
et:WindowStateSaveBehavior.IsStateSave="True"
```

上記のように本ビヘイビアをWindowに添付すると終了時に現在の位置、サイズ、WidnowStateプロパティを保存して、次回起動時に以前の状態を復元させることができます。

Windowを継承しているクラスにはすべて添付可能です。

