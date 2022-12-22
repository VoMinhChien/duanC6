// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AsmServer.Pages.MonAn
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
#line 2 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\MonAn\MonAnDetail.razor"
using AsmShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\MonAn\MonAnDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\MonAn\MonAnDetail.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monandia/{id}")]
    public partial class MonAnDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "F:\C6\TaiNguyenC6\download\Assignment2\Assignment1\Assignment\AsmSever\AsmServer\Pages\MonAn\MonAnDetail.razor"
       
    [Parameter]
    public string id{ get; set; }
    private AsmShare.Models.MonAn monAn{ get; set; }
    private string Tieude = "";
    IReadOnlyList<IBrowserFile> selectedFiles;
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tieude = "Thêm Món Ăn";
            monAn = new AsmShare.Models.MonAn();

        }
        else
        {
            Tieude = "Sửa Món Ăn";
            monAn = _monanservice.GetMonAn(int.Parse(id));
        }
    }
    private async void SubmitForm()
    {

        if (selectedFiles !=null && selectedFiles.Count>0)
        {

            //var rootpath = $"{env.WebRootPath}\\Images";
            //if (!Directory.Exists(rootpath))
            //{
            //    Directory.CreateDirectory(rootpath);
            //}

            //string dirPath = rootpath + @"\" + "monan";
            //if (!Directory.Exists(dirPath))
            //{
            //    Directory.CreateDirectory(dirPath);
            //}

            var file = selectedFiles[0];
            //string filePath = dirPath + @"\" + file.Name;
            {
                Stream stream = file.OpenReadStream();
                var path = $"{env.WebRootPath}\\Images\\monan\\{file.Name}";
                var paths = $"{ env.WebRootPath}\\Images\\monan\\{file.Name}";
                FileStream fs = File.Create(path);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }

            monAn.MonAn_Image = file.Name;

        }

        if (monAn.MonAn_Id == 0)      
        {
            var ngaytao = DateTime.Now;
            var ngaysua = DateTime.Now;
            monAn.MonAn_NgayTao = ngaytao;
            monAn.IsDelete = false;
            monAn.VAT = 10;
            monAn.MonAn_NgaySua = ngaysua;
            monAn.MonAn_GhiChu = "khongco";

            _monanservice.AddMonAn(monAn);
        }
        else
        { var ngaytao = DateTime.Now;
            var ngaysua = DateTime.Now;
            monAn.MonAn_NgayTao = ngaytao;
            monAn.IsDelete = false;
            monAn.VAT = 10;
            monAn.MonAn_NgaySua = ngaysua;
            monAn.MonAn_GhiChu = "khongco";
            _monanservice.EditMonAn(monAn.MonAn_Id, monAn);
        }
        navigation.NavigateTo("MonAnList");
    }
    public void Cancel()
    {
        navigation.NavigateTo("MonAnList");
    }
    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AsmShare.Services.IMonAnSvc _monanservice { get; set; }
    }
}
#pragma warning restore 1591
