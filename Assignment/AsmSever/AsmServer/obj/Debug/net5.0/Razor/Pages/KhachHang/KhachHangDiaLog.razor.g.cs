#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae0b2c1c1b84c11d058359e12f45ac5daf84214"
// <auto-generated/>
#pragma warning disable 1591
namespace AsmServer.Pages.KhachHang
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using AsmServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\_Imports.razor"
using AsmServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/KhachHangDialog/{id}")]
    public partial class KhachHangDiaLog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
__builder.AddContent(1, Tieude);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                          khachHang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "hidden");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                            khachHang.KhachHang_Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_Id = __value, khachHang.KhachHang_Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label class=\"control-label\">T??n Kh??ch H??ng</label>\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "disabled");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                  khachHang.KhachHang_Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_Name = __value, khachHang.KhachHang_Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 15 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label class=\"control-label\">Ng??y Sinh</label>\r\n                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "date");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "disabled");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              khachHang.KhachHang_NgaySinh

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_NgaySinh = __value, khachHang.KhachHang_NgaySinh, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 21 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_NgaySinh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label class=\"control-label\">Email</label>\r\n                    ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "disabled");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                  khachHang.KhachHang_Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_Email = __value, khachHang.KhachHang_Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 27 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n                \r\n                 ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label class=\"control-label\">SDT</label>\r\n                    ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "disabled");
                __builder2.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                  khachHang.KhachHang_Sdt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_Sdt = __value, khachHang.KhachHang_Sdt));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_3(__builder2, 64, 65, 
#nullable restore
#line 34 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_Sdt

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n                ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "<label for=\"khachHang.KhachHang_PassWord\" class=\"control-label\">Nh???p m???t kh???u</label>\r\n                    ");
                __builder2.OpenElement(70, "input");
                __builder2.AddAttribute(71, "type", "password");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "disabled");
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                                  khachHang.KhachHang_PassWord

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_PassWord = __value, khachHang.KhachHang_PassWord));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_4(__builder2, 77, 78, 
#nullable restore
#line 40 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_PassWord

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n                 ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<label for=\"khachHang.KhachHang_PassWord2\" class=\"control-label\">Nh???p m???t kh???u l???n 2</label>\r\n                    ");
                __builder2.OpenElement(83, "input");
                __builder2.AddAttribute(84, "type", "password");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "disabled");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                                  khachHang.KhachHang_PassWord2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_PassWord2 = __value, khachHang.KhachHang_PassWord2));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_5(__builder2, 90, 91, 
#nullable restore
#line 46 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_PassWord

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                 ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "<label class=\"control-label\">M?? t???</label>\r\n                    ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "disabled");
                __builder2.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                  khachHang.KhachHang_Mota

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachHang.KhachHang_Mota = __value, khachHang.KhachHang_Mota));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog.TypeInference.CreateValidationMessage_6(__builder2, 102, 103, 
#nullable restore
#line 51 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                              ()=>khachHang.KhachHang_Mota

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            \r\n                ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.OpenElement(107, "input");
                __builder2.AddAttribute(108, "type", "button");
                __builder2.AddAttribute(109, "class", "btn btn-primary");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "value", "Tho??t");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\KhachHang\KhachHangDiaLog.razor"
       
    [Parameter]
    public string id { get; set; }
    private AsmShare.Models.KhachHang khachHang{ get; set; }
    private string Tieude = "";
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tieude = "Th??m Kh??ch H??ng";
            khachHang = new AsmShare.Models.KhachHang();
        }
        else
        {
            Tieude = "S???a Kh??ch H??ng";
            khachHang= _khachhangService.GetKhachHang(int.Parse(id));
        }
    }
    private void SubmitForm()
    {
        if (khachHang.KhachHang_Id == 0)
        {
            //khachHang.KhachHang_Mota = "";
            _khachhangService.AddKhachHang(khachHang);
        }
        else
        {
           //khachHang.KhachHang_Mota = "";
            _khachhangService.EditKhachHang(khachHang.KhachHang_Id, khachHang);

        }
        navigation.NavigateTo("Khachhanglist");
    }
    private void Cancel()
    {
        navigation.NavigateTo("Khachhanglist", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AsmShare.Services.IKhachHang_Svc _khachhangService { get; set; }
    }
}
namespace __Blazor.AsmServer.Pages.KhachHang.KhachHangDiaLog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
