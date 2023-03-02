# CustomTitlebarWindow

![img1](./imgs/img1.png)

## 備考

タイトルバーを自由にカスタマイズ可能なWindow



## クラス情報

名前空間 : `EnkuToolkit.Wpf.Controls`<br/>アセンブリ : `EnkuToolkit.Wpf`<br/>xml名前空間 : `https://github.com/StdEnku/EnkuToolkit`



## 使い方

タイトルバーをカスタマイズ可能なWindowクラス<br/>FrameworkElement型のTitlebarプロパティを持ち、<br/>そこにタイトルバーの内容を書いていきます。<br/>また、タイトルバーのサイズはTitlebarプロパティ内の<br/>オブジェクトのHeightプロパティに依存します。

その他にもウィンドウのサイズ変更で使用する端の幅を指定するための<br/>ResizeBorderThicknessプロパティを持ちます。<br/>

```xaml
<et:CustomTitlebarWindow
    ~省略~
    xmlns:et="https://github.com/StdEnku/EnkuToolkit"
    ResizeBorderThickness="20, 0, 20, 20">

    <et:CustomTitlebarWindow.Titlebar>
        <!--タイトルバーの内容-->
        <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" Height="50">
            <Button Content="_" Click="MinimizeButtonClicked" Width="50" et:TitlebarComponentsBehavior.IsHitTestVisible="True" />
            <Button Content="□" Click="MaximizeButtonClicked" Width="50" et:TitlebarComponentsBehavior.IsHitTestVisible="True" />
            <Button Content="×" Click="ShutdownButtonClicked" Width="50" et:TitlebarComponentsBehavior.IsHitTestVisible="True" />
        </StackPanel>
    </et:CustomTitlebarWindow.Titlebar>

    <!--Contentプロパティは通常のWindowと同じように書ける-->
    <Viewbox>
        <Label Content="Hello World!" />
    </Viewbox>
</et:CustomTitlebarWindow>
```



注意点 :

> Titlebar内のボタンなどはそのままではウィンドウ移動用の領域と認識されてしまい、
>
> クリック等の操作ができないため対象のボタンなどに
>
> TitlebarComponentsBehavior.IsHitTestVisible添付プロパティを
>
> 添付して、その値にtrueを指定してください。

> 終了処理やWindowState変更処理などはコードビハインドで書いてください。

