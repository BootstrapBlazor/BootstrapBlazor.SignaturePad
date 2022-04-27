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
