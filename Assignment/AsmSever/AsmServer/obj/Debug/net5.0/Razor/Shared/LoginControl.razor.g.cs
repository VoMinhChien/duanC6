#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Shared\LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3452c2c156cc498b5ee514f9b1773be4bd9096"
// <auto-generated/>
#pragma warning disable 1591
namespace AsmServer.Shared
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
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Shared\LoginControl.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logincontrol")]
    public partial class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "b");
                __builder2.AddMarkupContent(3, "Xin Chào , ");
#nullable restore
#line 7 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Shared\LoginControl.razor"
__builder2.AddContent(4, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<b>Bạn Chắc Chắn muốn đăng xuất ?</b>\r\n        ");
                __builder2.AddMarkupContent(8, "<a class=\"ml-md-auto btn btn-primary\" href=\"/logout?returnUrl=/\" target=\"_top\">Logout</a>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591