using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AsmShare.Models;
using AsmShare.Models.ViewModels;
using AsmShare.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;


namespace AsmServer.Pages
{
    [AllowAnonymous]
    public class CheckLoginModel : PageModel
    {
        [Inject]
        public AsmShare.Services.INguoiDung_Svc _nguoidungService { get; set; }

        public CheckLoginModel(INguoiDung_Svc nguoidungService)
        {
            _nguoidungService = nguoidungService;
        }

        public string returnUrl { get; set; }
        public async Task<IActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch
            {

            }
            bool flagLogin = false;
            var viewLogin = new ViewLogin() { UserName = paramUsername, Password = paramPassword };
            AsmShare.Models.NguoiDung nguoidung = _nguoidungService.Login(viewLogin);
            if (nguoidung != null)
            {
                flagLogin = true;

            }

            if (flagLogin)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,paramUsername),
                    new Claim(ClaimTypes.Role,"Admin"),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };
                try
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.
                        AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }

            }
            else
            {

            }
            return LocalRedirect(returnUrl);
        }
    }
}
