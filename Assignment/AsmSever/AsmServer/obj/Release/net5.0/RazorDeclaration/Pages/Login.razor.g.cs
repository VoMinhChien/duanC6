// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AsmServer.Pages
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
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\Login.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\Login.razor"
       
    private bool loadding;
    private string error;
    string username = "";
    string password = "";
    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }
    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if (password != "")
            {
                CheckLogin();
            }
        }
    }
    public void CheckLogin()
    {
        error = "";
        if (username == "")
        {
            error = "Bạn cần nhập user name ";
        }
        if (password == "")
        {
            error += (error == "" ? "" : "<br/>") + "Bạn cần nhập password";
        }
        if (error == "")
        {
            NavigationManager.NavigateTo("CheckLogin?paramUsername=" + @Encode(@username) + "&paramPassword=" + @Encode(@password), true);
           
           
        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
