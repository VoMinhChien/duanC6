using AsmShare.Models;
using AsmShare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private readonly IDonHang_Svc _donhangSvc;
        public DonHangController(IDonHang_Svc donhangSvc)
        {
            _donhangSvc = donhangSvc;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonHang>>> GetDonHangByKhachHang([FromQuery]int id)
        {
            var listDonHang= await _donhangSvc.GetDonHangByKhachHangAsync(id);
            return listDonHang;
        }
    }
}
