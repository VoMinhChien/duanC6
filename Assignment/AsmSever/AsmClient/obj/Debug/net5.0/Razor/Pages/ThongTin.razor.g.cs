#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e171035135b3571f771adf101e531228ca5a4b99"
// <auto-generated/>
#pragma warning disable 1591
namespace AsmClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using AsmClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using AsmClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
using AsmShare.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
using AsmShare.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
using Net.ConnectCode.Barcode;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayOut))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/thongtin/{id}")]
    public partial class ThongTin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-8");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.AddMarkupContent(4, "<div class=\"card-header py-3\"><h5 class=\"mb-0\">Thông Tin Của Bạn</h5></div>\r\n                      ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "<img src=\"Images/logochiens.png\">\r\n                         ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "list-group list-group-flush");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0");
            __builder.AddMarkupContent(16, "\r\n                  Họ Tên\r\n                  ");
            __builder.OpenElement(17, "span");
#nullable restore
#line 27 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
__builder.AddContent(18, list.KhachHang_Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "list-group-item d-flex justify-content-between align-items-center px-0");
            __builder.AddMarkupContent(22, "\r\n                  Email\r\n                  ");
            __builder.OpenElement(23, "span");
#nullable restore
#line 31 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
__builder.AddContent(24, list.KhachHang_Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "list-group-item d-flex justify-content-between align-items-center px-0");
            __builder.AddMarkupContent(28, "\r\n                  Ngày Sinh\r\n                  ");
            __builder.OpenElement(29, "span");
#nullable restore
#line 35 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
__builder.AddContent(30, Convert.ToDateTime(@list.KhachHang_NgaySinh).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "list-group-item d-flex justify-content-between align-items-center px-0");
            __builder.AddMarkupContent(33, "\r\n                  Số điện thoại\r\n                  ");
            __builder.OpenElement(34, "span");
#nullable restore
#line 38 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
__builder.AddContent(35, list.KhachHang_Sdt);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n              ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "href", "/suathongtin/" + (
#nullable restore
#line 41 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
                                                             id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "Sửa");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n              ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "href", "/doipass/" + (
#nullable restore
#line 42 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
                                                         id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "Đổi Mật Khẩu");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\ThongTin.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Tieude = "";
    protected string temp = "";
    protected string imgUrl = "";
    public KhachHang list;
   
   
    protected override async Task OnInitializedAsync()
    {


        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        list = new KhachHang();
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("https://localhost:44345/api/khachhang/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<KhachHang>(apiResponse);
              
            }
            }
        


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
