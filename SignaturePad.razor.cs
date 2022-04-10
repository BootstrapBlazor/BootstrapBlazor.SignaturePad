using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.Components;

/// <summary>
/// SignaturePad 签名
/// </summary>
public partial class SignaturePad : IDisposable
{
    private JSInterop<SignaturePad>? Interop { get; set; }

    /// <summary>
    /// 手写签名结果回调/SignaturePad result callback method
    /// </summary>
    [Parameter]
    public Func<string, Task>? OnResult { get; set; }

    /// <summary>
    /// 手写签名警告信息回调/SignaturePad alert callback method
    /// </summary>
    [Parameter]
    public Func<string, Task>? OnAlert { get; set; }

    /// <summary>
    /// 手写签名关闭信息回调/SignaturePad close callback method
    /// </summary>
    [Parameter]
    public Func<Task>? OnClose { get; set; }

    /// <summary>
    /// 获得/设置 错误回调方法
    /// </summary>
    [Parameter]
    public Func<string, Task>? OnError { get; set; }

    /// <summary>
    /// 在框内签名标签文本/Sign above label
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SignAboveLabel { get; set; } = "在框内签名";
    /// <summary>
    /// 清除按钮文本/Clear button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? ClearBtnTitle { get; set; } = "清除";

    /// <summary>
    /// 请先签名提示文本/'Please provide a signature first' alert text
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SignatureAlertText { get; set; } = "请先签名";

    /// <summary>
    /// 换颜色按钮文本/Change color button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? ChangeColorBtnTitle { get; set; } = "换颜色";

    /// <summary>
    /// 撤消按钮文本/Undo button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? UndoBtnTitle { get; set; } = "撤消";

    /// <summary>
    /// 关闭按钮文本/Close button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? CloseBtnTitle { get; set; } = "关闭";

    /// <summary>
    /// 保存为base64按钮文本/Save as Base64 button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SaveBase64BtnTitle { get; set; } = "确定";

    /// <summary>
    /// 保存为PNG按钮文本/Save as PNG button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SavePNGBtnTitle { get; set; } = "PNG";

    /// <summary>
    /// 保存为JPG按钮文本/Save as JPG button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SaveJPGBtnTitle { get; set; } = "JPG";

    /// <summary>
    /// 保存为SVG按钮文本/Save as SVG button title
    /// </summary>
    [Parameter]
    [NotNull]
    public string? SaveSVGBtnTitle { get; set; } = "SVG";

    /// <summary>
    /// 启用换颜色按钮/Enable change color button
    /// </summary>
    [Parameter]
    [NotNull]
    public bool EnableChangeColorBtn { get; set; } = true;

    /// <summary>
    /// 启用JS错误弹窗/Enable Alert from JS
    /// </summary>
    [Parameter]
    [NotNull]
    public bool EnableAlertJS { get; set; } = true;

    /// <summary>
    /// 启用保存为base64按钮/Enable save as Base64 button
    /// </summary>
    [Parameter]
    [NotNull]
    public bool EnableSaveBase64Btn { get; set; } = true;

    /// <summary>
    /// 启用保存为PNG按钮文本/Enable save as PNG button
    /// </summary>
    [Parameter]
    [NotNull]
    public bool EnableSavePNGBtn { get; set; } = false;

    /// <summary>
    /// 启用保存为JPG按钮文本/Enable save as JPG button
    /// </summary>
    [Parameter]
    [NotNull]
    public bool EnableSaveJPGBtn { get; set; } = false;

    /// <summary>
    /// 启用保存为SVG按钮文本/Enable save as SVG button
    /// </summary>
    [Parameter]
    public bool EnableSaveSVGBtn { get; set; } = false;

    /// <summary>
    /// 按钮CSS式样/Button css style
    /// </summary>
    [Parameter]
    public string BtnCssClass { get; set; } = "btn btn-light";

    /// <summary>
    /// 组件CSS式样/Components css style
    /// </summary>
    [Parameter]
    [NotNull]
    public string CssClass { get; set; } = "signature-pad-body";

    /// <summary>
    /// 响应式css界面,为所有用户设计最佳体验/Enable Responsive css
    /// </summary>
    [Parameter]
    [NotNull]
    public bool Responsive { get; set; } = false;

    /// <summary>
    /// 组件背景/backgroundColor
    /// </summary>
    [Parameter]
    [NotNull]
    public string BackgroundColor { get; set; } = "rgb(255, 255, 255)";

    /// <summary>
    /// 动态JS模块
    /// </summary>
    private IJSObjectReference? module;

    /// <summary>
    ///
    /// </summary>
    protected ElementReference SignaturepadElement { get; set; }

    [Inject]
    [NotNull]
    private IStringLocalizer<SignaturePad>? Localizer { get; set; }

    /// <summary>
    /// OnInitialized 方法
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();


        SignAboveLabel ??= LocalizerLabel(nameof(SignAboveLabel));
        ClearBtnTitle ??= LocalizerLabel(nameof(ClearBtnTitle));
        SignatureAlertText ??= LocalizerLabel(nameof(SignatureAlertText));
        ChangeColorBtnTitle ??= LocalizerLabel(nameof(ChangeColorBtnTitle));
        UndoBtnTitle ??= LocalizerLabel(nameof(UndoBtnTitle));
        CloseBtnTitle ??= LocalizerLabel(nameof(CloseBtnTitle));
        SaveBase64BtnTitle ??= LocalizerLabel(nameof(SaveBase64BtnTitle));
        SavePNGBtnTitle ??= LocalizerLabel(nameof(SavePNGBtnTitle));
        SaveJPGBtnTitle ??= LocalizerLabel(nameof(SaveJPGBtnTitle));
        SaveSVGBtnTitle ??= LocalizerLabel(nameof(SaveSVGBtnTitle));
    }

    private string LocalizerLabel(string key) => Localizer[key].ResourceNotFound ? key : Localizer[key];

    /// <summary>
    /// OnAfterRenderAsync 方法
    /// </summary
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                module = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BootstrapBlazor.SignaturePad/lib/signature_pad/app.js");
                Interop = new JSInterop<SignaturePad>(JSRuntime);
                await module.InvokeVoidAsync("init", DotNetObjectReference.Create(this), SignaturepadElement, EnableAlertJS ? SignatureAlertText : null, BackgroundColor);
                //await module.InvokeVoidAsync(this, SignaturepadElement, "bb_SignaturePad",  EnableAlertJS ? SignatureAlertText : "", BackgroundColor );
            }
            catch (Exception e)
            {
                if (OnError != null) await OnError.Invoke(e.Message);
            }
        }
    }

    /// <summary>
    /// 签名完成回调方法
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    [JSInvokable("signatureResult")]
    public async Task SignatureResult(string? val)
    {
        if (OnResult != null) await OnResult.Invoke(val ?? "");
    }

    /// <summary>
    /// 告警回调方法
    /// </summary>
    /// <returns></returns>
    [JSInvokable("signatureAlert")]
    public async Task SignatureAlert()
    {
        if (OnAlert != null) await OnAlert.Invoke(SignatureAlertText);
    }

    /// <summary>
    /// 关闭回调方法
    /// </summary>
    /// <returns></returns>
    public async Task Close()
    {
        if (OnClose != null) await OnClose.Invoke();
    }

    /// <summary>
    /// Dispose 方法
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (Interop != null)
            {
                Interop.Dispose();
                Interop = null;
            }
        }
    }

    /// <summary>
    /// Dispose 方法
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

}
