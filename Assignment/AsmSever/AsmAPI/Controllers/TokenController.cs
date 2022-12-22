using AsmShare.Models.ViewModels;
using AsmShare.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TokenController : ControllerBase
    {
        public IKhachHang_Svc _khachhangSvc;
        public IConfiguration _configuration;
        public TokenController(IKhachHang_Svc khachhangSvc, IConfiguration configuration)
        {
            _khachhangSvc = khachhangSvc;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ViewWebLogin viewWebLogin)
        {
            if (viewWebLogin != null && !string.IsNullOrEmpty(viewWebLogin.Email) && !string.IsNullOrEmpty(viewWebLogin.Password))
            {
                var khachhang = _khachhangSvc.Login(viewWebLogin);
                if (khachhang != null)
                {
                    if (khachhang != null)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                            new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                            new Claim("Id",khachhang.KhachHang_Id.ToString()),
                            new Claim("FullName",khachhang.KhachHang_Name),
                            new Claim("Email",khachhang.KhachHang_Email),
                            

                        };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                        var singIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: singIn);
                        ViewToken viewToken = new ViewToken()
                        {
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                            KhachHang_Id = khachhang.KhachHang_Id,
                            KhachHang_Name = khachhang.KhachHang_Name,
                            KhachHang_sdt = khachhang.KhachHang_Sdt,
                            
                            
                        };
                        return Ok(viewToken);
                    }
                    else
                    {
                        return BadRequest("Invalid credentials");
                    }
                }
                else { return BadRequest(); }
            }
            return BadRequest();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpPut("{id}")]
        public async Task<IActionResult> DoiPass(ViewDoiPass viewdoipass)
        {
            if (viewdoipass != null && !string.IsNullOrEmpty( (viewdoipass.IdKhachHang).ToString()) && !string.IsNullOrEmpty(viewdoipass.Password))
            {
                var khachhang = _khachhangSvc.DoiPass(viewdoipass);
                
                
            }
            return BadRequest();
        }
    }
}
