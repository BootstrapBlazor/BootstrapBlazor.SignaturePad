## Blazor SignaturePad 手写签名 组件 

### 示例

https://www.blazor.zone/signaturepads

https://blazor.app1.es/signaturepad

## 使用方法:

1. nuget包

    ```BootstrapBlazor.SignaturePad```

2. _Imports.razor 文件 或者页面添加 添加组件库引用

    ```@using BootstrapBlazor.Components```


3. Razor页面

    ```
        <SignaturePad OnResult="((e) =>  Result=e)" />
    ```
    ```
        <SignaturePad OnResult="((e) =>  Result=e)" BtnCssClass="btn btn-outline-success" />
    ```
    ```
        <SignaturePad OnResult="((e) =>  Result=e)"
                      SignAboveLabel="Sign above"
                      UndoBtnTitle="Undo"
                      SaveBase64BtnTitle="OK"
                      ChangeColorBtnTitle="Change color"
                      ClearBtnTitle="Clear" />
    ```

    ```
    @code{

        /// <summary>
        /// 签名Base64
        /// </summary>
        public string? Result { get; set; }

    }
    ```

4. 更多信息请参考

    Bootstrap 风格的 Blazor UI 组件库
基于 Bootstrap 样式库精心打造，并且额外增加了 100 多种常用的组件，为您快速开发项目带来非一般的感觉

    <https://www.blazor.zone>

    <https://www.blazor.zone/signaturepads>

---- 
#### 更新历史

v7.0.3
- 清除按钮改为不触发 OnResult 事件

v7.0.2
- 添加 EnableUndoBtn : 启用撤消按钮/Enable undo button
- 添加 BtnSaveCssClass : 按钮 "保存 "的css样式
- 感谢 ArtemAksenov's pr.

## Blazor SignaturePad component
 

### Demo

https://www.blazor.zone/signaturepads

https://blazor.app1.es/signaturepad

## Instructions:

1. NuGet install pack 

    `BootstrapBlazor.OnScreenKeyboard`

2. _Imports.razor or Razor page

   ```
   @using BootstrapBlazor.Components
   ```
3. Razor page

    ```
        <SignaturePad OnResult="((e) =>  Result=e)" />
    ```
    ```
        <SignaturePad OnResult="((e) =>  Result=e)" BtnCssClass="btn btn-outline-success" />
    ```
    ```
        <SignaturePad OnResult="((e) =>  Result=e)"
                      SignAboveLabel="Sign above"
                      UndoBtnTitle="Undo"
                      SaveBase64BtnTitle="OK"
                      ChangeColorBtnTitle="Change color"
                      ClearBtnTitle="Clear" />
    ```

    ```
    @code{

        /// <summary>
        /// Sign Base64
        /// </summary>
        public string? Result { get; set; }

    }
    ```

4.  More informations

    Bootstrap style Blazor UI component library
Based on the Bootstrap style library, it is carefully built, and 100 a variety of commonly used components have been added to bring you an extraordinary feeling for rapid development projects

    <https://www.blazor.zone>

    <https://www.blazor.zone/signaturepads>

#### Historial de actualizaciones

v7.0.2
- Add EnableUndoBtn : Enable undo button
- Add BtnSaveCssClass : Button "Save" css style
- Thanks ArtemAksenov's pr.

---
#### Blazor 组件

[条码扫描 ZXingBlazor](https://www.nuget.org/packages/ZXingBlazor#readme-body-tab)
[![nuget](https://img.shields.io/nuget/v/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/packages/ZXingBlazor) 
[![stats](https://img.shields.io/nuget/dt/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/stats/packages/ZXingBlazor?groupby=Version)

[图片浏览器 Viewer](https://www.nuget.org/packages/BootstrapBlazor.Viewer#readme-body-tab)
  
[条码扫描 BarcodeScanner](Densen.Component.Blazor/BarcodeScanner.md)
   
[手写签名 Handwritten](Densen.Component.Blazor/Handwritten.md)

[手写签名 SignaturePad](https://www.nuget.org/packages/BootstrapBlazor.SignaturePad#readme-body-tab)

[定位/持续定位 Geolocation](https://www.nuget.org/packages/BootstrapBlazor.Geolocation#readme-body-tab)

[屏幕键盘 OnScreenKeyboard](https://www.nuget.org/packages/BootstrapBlazor.OnScreenKeyboard#readme-body-tab)

[百度地图 BaiduMap](https://www.nuget.org/packages/BootstrapBlazor.BaiduMap#readme-body-tab)

[谷歌地图 GoogleMap](https://www.nuget.org/packages/BootstrapBlazor.Maps#readme-body-tab)

[蓝牙和打印 Bluetooth](https://www.nuget.org/packages/BootstrapBlazor.Bluetooth#readme-body-tab)

[PDF阅读器 PdfReader](https://www.nuget.org/packages/BootstrapBlazor.PdfReader#readme-body-tab)

[文件系统访问 FileSystem](https://www.nuget.org/packages/BootstrapBlazor.FileSystem#readme-body-tab)

[光学字符识别 OCR](https://www.nuget.org/packages/BootstrapBlazor.OCR#readme-body-tab)

[电池信息/网络信息 WebAPI](https://www.nuget.org/packages/BootstrapBlazor.WebAPI#readme-body-tab)

#### AlexChow

[今日头条](https://www.toutiao.com/c/user/token/MS4wLjABAAAAGMBzlmgJx0rytwH08AEEY8F0wIVXB2soJXXdUP3ohAE/?) | [博客园](https://www.cnblogs.com/densen2014) | [知乎](https://www.zhihu.com/people/alex-chow-54) | [Gitee](https://gitee.com/densen2014) | [GitHub](https://github.com/densen2014)


![ChuanglinZhou](https://user-images.githubusercontent.com/8428709/205942253-8ff5f9ca-a033-4707-9c36-b8c9950e50d6.png)

![Alex Chow's GitHub stats](https://github-readme-stats.vercel.app/api?username=densen2014&include_all_commits=true&count_private=true&show_icons=true)

![Top Langs](https://github-readme-stats.vercel.app/api/top-langs/?username=densen2014&layout=compact)
