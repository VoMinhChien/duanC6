#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93dd51ede5a3ddf4fcabd695d3a41042b04afbb"
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
#line 11 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\_Imports.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
using AsmShare.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayOut))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/doipass/{id}")]
    public partial class DoiPass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-8");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.AddMarkupContent(4, "<div class=\"card-header py-3\"><h5 class=\"mb-0\">Đổi Mật khẩu</h5></div>\r\n                      ");
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
            __builder.AddMarkupContent(16, "\r\n                          Mật khẩu cũ:\r\n                          ");
            __builder.OpenElement(17, "span");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "pass cũ");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
                                              password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "list-group-item d-flex justify-content-between align-items-center px-0");
            __builder.AddMarkupContent(25, "\r\n                          Mật khẩu mới:\r\n                          ");
            __builder.OpenElement(26, "span");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "placeholder", "pass mới");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
                                               passwordnew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => passwordnew = __value, passwordnew));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n              \r\n             ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-primary w-50 py-2 mt-4 d-block mx-auto");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
                                                                                      CheckPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, " Đổi");
            __builder.CloseElement();
#nullable restore
#line 39 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
                 if (!string.IsNullOrEmpty(error))
                 {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "alert alert-danger mt-3 mb-0");
#nullable restore
#line 41 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
__builder.AddContent(38, (MarkupString)error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
        
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\DoiPass.razor"
       
    [Parameter]
    public string id { get; set; }
    private string error;

    private string Tieude = "";
    protected string temp = "";
    protected string imgUrl = "";
    public KhachHang list;
    string password = "";
    string passwordnew2 = "";
    string passwordnew = "";
    private async Task CheckPass()
    {
      
        error = "";
        if (password == "")
        {
            error = " - Bạn cần nhập Mật Khẩu cũ.";
        }
        if (passwordnew == "")
        {
            error += (error == "" ? "" : "<br/>") + " - Bạn cần nhập Mật khẩu mới.";
        }   
        if (error == "")
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            ViewDoiPass viewDoiPass = new ViewDoiPass() {IdKhachHang=int.Parse( id), Password = password, PasswordNew = passwordnew };

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await Http.PutAsJsonAsync("https://localhost:44345/api/token/" + id.ToString(), viewDoiPass)) ;
                error = "đổi mật khẩu thành công";
            }
            
            
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
