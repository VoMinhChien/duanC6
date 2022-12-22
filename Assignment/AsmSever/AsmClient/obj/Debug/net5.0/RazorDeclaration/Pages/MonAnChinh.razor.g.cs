// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\MonAnChinh.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\MonAnChinh.razor"
using AsmShare.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\MonAnChinh.razor"
using AsmShare.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayOut))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/monanchinh/1")]
    public partial class MonAnChinh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmClient\Pages\MonAnChinh.razor"
       
    private string name;
    public List<MonAn> monAns;
    protected string imgUrl="";
    protected string temp = "";
    //protected void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
        //sessionStorage.SetItem("name", "John Smith");
        //var name = sessionStorage.GetItem<string>("name");

        //monAns = _monAnService.GetMonAnAll();

        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        monAns = new List<MonAn>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("MonAn"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                monAns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
            }
        }
    }
    //AsmShare.Services.IMonAnSvc hi;
    //private void detailsmonan(int id)
    //{
        
    //    hi.GetMonAn(id);
        

    //}

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
