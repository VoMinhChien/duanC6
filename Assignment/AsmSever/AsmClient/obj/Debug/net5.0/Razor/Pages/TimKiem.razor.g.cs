#pragma checksum "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0ad2deecef0fdb7e90e2b1cb70825e4affc961"
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
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
using AsmShare.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
using AsmShare.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/timkiem/{search}")]
    public partial class TimKiem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .list-product {
        margin: auto;
        display: flex;
        flex-wrap: wrap;
    }

    .product {
        margin-top: 10px;
        margin-right: 10px;
        width: 205px;
    }

    .img {
        width: 150px;
        display: block;
        margin: auto;
    }

    .title {
        color: #0e0e0e;
        display: block;
        font-size: 15px;
        font-weight: bold;
        text-align: center;
        height: 60px;
    }

    .field-price {
        font-size: 24px;
        color: #d50000;
        margin-bottom: 15px;
        font-weight: 700;
        text-align: center;
    }

    .viewProduct, .addProduct {
        border: 0;
        font-weight: 700;
        padding: 9px 5px;
        background: #ffd800;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
        display: block;
        width: 186px;
        margin: 0 auto;
        color: #0e0e0e;
    }

    .addProduct {
        margin-left: 2px;
    }
</style>
<link rel=""stylesheet"" type=""text/css"" href=""//fonts.googleapis.com/css?family=Roboto:100,300,300i,400,500,600,700,900%7CRaleway:500"">
    <link rel=""stylesheet"" href=""cssSP/bootstrap.css"">
    <link rel=""stylesheet"" href=""cssSP/fonts.css"">
     <link rel=""stylesheet"" href=""cssSP/style.css"">



    
  
");
            __builder.AddMarkupContent(1, "<h1>index</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-product");
#nullable restore
#line 77 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
     foreach (var item in monAns)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-6 col-lg-4 col-xl-3");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", "Images/monan/" + (
#nullable restore
#line 85 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
                                    item.MonAn_Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "product-figure");
            __builder.AddAttribute(9, "style", "width:230px;height:230px;border-radius:3px");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            <div></div>\r\n            ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "title");
#nullable restore
#line 90 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
__builder.AddContent(13, item.MonAn_Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n           \r\n            \r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", " color:orangered;font-size:35px");
#nullable restore
#line 93 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
__builder.AddContent(17, string.Format("{0:N0}",@item.MonAn_Gia));

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<a>VND</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                  ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "button-wrap");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "button button-xs button-primary button-winona");
            __builder.AddAttribute(25, "onmouseup", "addCart(" + (
#nullable restore
#line 96 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
                                                                                                                         item.MonAn_Id

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
                                                                                                                                                    () => AddCart(item.MonAn_Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "style", "width:230px");
            __builder.AddMarkupContent(28, "Thêm vào Giỏ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                  ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "button-wrap");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "button button-xs button-secondary button-winona");
            __builder.AddAttribute(34, "href", "/detailsmonan/" + (
#nullable restore
#line 97 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
                                                                                                                           item.MonAn_Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "style", "width:230px");
            __builder.AddMarkupContent(36, "Chi Tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\TimKiem.razor"
       
    [Parameter]
    public string search { get; set; }
    private string name;
    public List<MonAn> monAns;
    protected string imgUrl="";
    protected string temp = "";
    //protected void OnInitialized()
    protected override async Task OnParametersSetAsync()
    {

        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        monAns = new List<MonAn>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            //client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            //client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("https://localhost:44345/api/monan/"+search))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                monAns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
            }
        }

    }

    private void AddCart(int id)
    {
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart
        if (cart == null)
        {

            var monAn = monAns.Where(u=>u.MonAn_Id==id).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
                {
                    new CartItem
                    {
                        MonAn = monAn,
                        Quantity = 1,
                        Sotien= monAn.MonAn_Gia,
                        
                    }
            };

           AsmShare.Models.ViewModels.Cart giohang = new AsmShare.Models.ViewModels.Cart() {
                ListViewCart = listCart, Tongtien = Tinhtien(listCart) };

            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            var monAn = monAns.Where(u => u.MonAn_Id == id).FirstOrDefault();

            AsmShare.Models.ViewModels.Cart giohang = JsonConvert.DeserializeObject<AsmShare.Models.ViewModels.Cart>(cart);
            //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
            bool check = true;
            for (int i = 0; i < giohang.ListViewCart.Count; i++)
            {
                if (giohang.ListViewCart[i].MonAn.MonAn_Id == id)
                {
                    giohang.ListViewCart[i].Quantity++;
                    giohang.ListViewCart[i].Sotien = monAn.MonAn_Gia * giohang.ListViewCart[i].Quantity;
                   
                    check = false;
                }
            }

            if (check)
            {
                //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                giohang.ListViewCart.Add(new CartItem
                {
                    MonAn = monAn,
                    Quantity = 1,
                    Sotien= monAn.MonAn_Gia*1
                    
                    
                });
            }
            giohang.Tongtien = Tinhtien(giohang.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));

            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }
    }

    private float Tinhtien(List<CartItem> listCart)
    {
        float tongtien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongtien += listCart[i].Sotien;
            }
        }
        return tongtien;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
