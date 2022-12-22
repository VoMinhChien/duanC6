using AsmShare.Models;
using AsmShare.Models.ViewModels;
using AsmShare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IDonHang_Svc _donhangSvc;
        private readonly IChiTietDonHang_Svc _chitietDonhangSvc;
        public CartController(IDonHang_Svc donhangSvc, IChiTietDonHang_Svc chitietDonhangSvc)
        {
            _donhangSvc = donhangSvc;
            _chitietDonhangSvc = chitietDonhangSvc;
        }
        [HttpPost]
        public async Task<ActionResult<int>> PostCart(Cart giohang)
        {
            try
            {

              
                
                var donhang = new DonHang()
                {

                    HoaDon_TrangThai = TrangthaiDonhang.Moidat,
                    KhachHang_Id = giohang.KhanghangId,
                    GiaTienChuaVAT = giohang.Tongtien,
                    NgayDat = DateTime.Now,
                    KhachHang_Name = giohang.KhachhangName,
                    KhachHang_Email = giohang.KhachHangEmail,
                    KhachHang_SoDienThoai = giohang.KhachHangSdt,
                    KhachHang_DiaChi=giohang.KhachHangDiachi,
                    VAT = 10,
                    IsDelete = false,
                    GiaTienDaVAT = (float)(giohang.Tongtien + (giohang.Tongtien * 0.1))

                    //GiaTienDaVAT = 0,
                };
                int donHangID = await _donhangSvc.AddDonHangAsync(donhang)
;               donhang.DonHang_Id = donHangID;
                List<CartItem> dataCart = giohang.ListViewCart;
                for(int i = 0; i < dataCart.Count; i++)
                {
                    ChiTietDonHang chitiet = new ChiTietDonHang()
                    {
                        DonHang_Id = donHangID,
                        MonAn_Id = dataCart[i].MonAn.MonAn_Id,
                        MonAn_SoLuong = dataCart[i].Quantity,
                        MonAn_Name = dataCart[i].MonAn.MonAn_Name,
                        MonAn_Image = dataCart[i].MonAn.MonAn_Image,        
                        MonAn_Gia = (float)(( dataCart[i].MonAn.MonAn_Gia * dataCart[i].Quantity)+(dataCart[i].MonAn.MonAn_Gia * dataCart[i].Quantity * 0.1)) ,
                        VAT = 10,
                        IsDelete=false,
                        
                    };
                    _chitietDonhangSvc.AddChiTietDonHangSvc(chitiet);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(-1);
            }
            return Ok(1);
        }

       
    }
}
