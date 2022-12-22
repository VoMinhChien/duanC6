using AsmShare.Models;
using AsmShare.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KhachHangController : ControllerBase
    {

        private readonly IKhachHang_Svc _khachhangSvc;
        public KhachHangController(IKhachHang_Svc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
        }
        [HttpPost]
        public async Task<ActionResult<int>> PostKhachhang(KhachHang khachhang)
        {
            try
            {
                //int id= await _khachhangSvc.AddKhachhang(khachhang);
                int id = await _khachhangSvc.AddKhachHangAsync(khachhang);
                khachhang.KhachHang_Id = id;
            }
            catch (Exception ex)
            {
                // return BadRequest(-1);
            }
            return Ok(1);
        }
        [HttpGet]
        public async Task<ActionResult<KhachHang>> GetKhachhang(int id)
        {
            try
            {
                //int id= await _khachhangSvc.AddKhachhang(khachhang);
                //var khachhang = await _khachhangSvc.GetKhachhang(id);
                //khachhang.KhachhangID = id;
            }
            catch (Exception ex)
            {
                // return BadRequest(-1);
            }
            return Ok(1);
        }
        [HttpGet("{id}")]
        public KhachHang ThongTin(int id)
        {
            return _khachhangSvc.GetKhachHang(id);
        }
        [HttpPut("{id}")]
        public KhachHang SuaThongTin(int id, KhachHang khachHang)
        {
            
            _khachhangSvc.KHEditKhachHang(id, khachHang);
            return khachHang;
        }
    }
}
