#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41651fe668f5e5d3d89b84a3f81df51ef790ac5b"
// <auto-generated/>
#pragma warning disable 1591
namespace AsmServer.Pages.DonHang
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
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DonHangDialog/{id}")]
    public partial class DonHangDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
#nullable restore
#line 8 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
__builder.AddContent(1, Tieude);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n<hr>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                          donhang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
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
#line 14 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                            donhang.DonHang_Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.DonHang_Id = __value, donhang.DonHang_Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "hidden");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                                 donhang.KhachHang_Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachHang_Id = __value, donhang.KhachHang_Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label class=\"control-label\">Email</label>\r\n                    ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "disabled");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.KhachHang.KhachHang_Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachHang.KhachHang_Email = __value, donhang.KhachHang.KhachHang_Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 23 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.KhachHang_Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label class=\"control-label\">Name</label>\r\n                    ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "disabled");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.KhachHang_Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachHang_Name = __value, donhang.KhachHang_Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 29 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.KhachHang_Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "<label class=\"control-label\">Sdt</label>\r\n                    ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "disabled");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.KhachHang_SoDienThoai

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachHang_SoDienThoai = __value, donhang.KhachHang_SoDienThoai));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 35 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.KhachHang_SoDienThoai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n               ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "<label class=\"control-label\">Dia chi</label>\r\n                    ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "disabled");
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.KhachHang_DiaChi

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachHang_DiaChi = __value, donhang.KhachHang_DiaChi));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 41 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.KhachHang_DiaChi

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n\r\n                 ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "<label class=\"control-label\">Tr???ng Th??i</label>\r\n                     ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateInputSelect_4(__builder2, 75, 76, "form-control", 77, 
#nullable restore
#line 47 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                                donhang.HoaDon_TrangThai

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => donhang.HoaDon_TrangThai = __value, donhang.HoaDon_TrangThai)), 79, () => donhang.HoaDon_TrangThai, 80, (__builder3) => {
#nullable restore
#line 48 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                     foreach (var hi in Enum.GetValues(typeof(TrangthaiDonhang)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(81, "option");
                    __builder3.AddAttribute(82, "value", 
#nullable restore
#line 50 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                        hi

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 51 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
__builder3.AddContent(83, hi);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 53 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    \r\n                ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group");
                __builder2.AddMarkupContent(87, "<label class=\"control-label\">ch??a vat</label>\r\n                    ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "disabled");
                __builder2.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.GiaTienChuaVAT

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.GiaTienChuaVAT = __value, donhang.GiaTienChuaVAT));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_5(__builder2, 94, 95, 
#nullable restore
#line 61 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.GiaTienChuaVAT

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "<label class=\"control-label\">???? vat</label>\r\n                    ");
                __builder2.OpenElement(100, "input");
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "disabled");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.GiaTienDaVAT

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.GiaTienDaVAT = __value, donhang.GiaTienDaVAT));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_6(__builder2, 106, 107, 
#nullable restore
#line 66 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.GiaTienDaVAT

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                 ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group");
                __builder2.AddMarkupContent(111, "<label class=\"control-label\">vat</label>\r\n                    ");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "disabled");
                __builder2.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                  donhang.VAT

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.VAT = __value, donhang.VAT));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_7(__builder2, 118, 119, 
#nullable restore
#line 71 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.VAT

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "form-group");
                __builder2.AddMarkupContent(123, "<label for=\"hoadon.NgayDat\" class=\"control-label\">Ng??y ?????t</label>\r\n                    ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "type", "date");
                __builder2.AddAttribute(126, "class", "form-control");
                __builder2.AddAttribute(127, "disabled");
                __builder2.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              donhang.NgayDat

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.NgayDat = __value, donhang.NgayDat, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __Blazor.AsmServer.Pages.DonHang.DonHangDialog.TypeInference.CreateValidationMessage_8(__builder2, 131, 132, 
#nullable restore
#line 76 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                              ()=>donhang.NgayDat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\r\n             \r\n\r\n                  ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "form-group form-check");
                __builder2.OpenElement(136, "label");
                __builder2.AddAttribute(137, "class", "form-check-label");
                __builder2.OpenElement(138, "input");
                __builder2.AddAttribute(139, "type", "checkbox");
                __builder2.AddAttribute(140, "class", "form-check-input");
                __builder2.AddAttribute(141, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                                                               donhang.IsDelete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.IsDelete = __value, donhang.IsDelete));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "Isdelete\r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n\r\n               \r\n                ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-group");
                __builder2.AddMarkupContent(147, "<button type=\"submit\" class=\"btn btn-info\">L??u</button>\r\n                    ");
                __builder2.OpenElement(148, "input");
                __builder2.AddAttribute(149, "type", "button");
                __builder2.AddAttribute(150, "class", "btn btn-primary");
                __builder2.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "value", "Tho??t");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.AddMarkupContent(154, "<div><a asp-action=\"Index\">Back to list</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\DonHang\DonHangDialog.razor"
       
    [Parameter]
    public string id{ get; set; }
    private AsmShare.Models.DonHang donhang{ get; set; }

    private string Tieude = "";
    IReadOnlyList<IBrowserFile> selecredFiles;
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            navigation.NavigateTo("DonHangList", true);
        }
        else
        {
            Tieude = "S???a ????n h??ng";
           
            donhang = _donHangService.GetDonHang(int.Parse(id));
        }
    }
    
    private async void SubmitForm()
    {
       
        _donHangService.EditDonHang(donhang.DonHang_Id, donhang);
        navigation.NavigateTo("DonHangList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("DonHangList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AsmShare.Services.IDonHang_Svc _donHangService { get; set; }
    }
}
namespace __Blazor.AsmServer.Pages.DonHang.DonHangDialog
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
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
