using AsmShare.Models;
using AsmShare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietDonHangController : ControllerBase
    {
        private readonly IChiTietDonHang_Svc _chiTietDonHangSvc;
        private readonly IDonHang_Svc _donhangSvc;
        public ChiTietDonHangController(IChiTietDonHang_Svc chiTietDonHangSvc, IDonHang_Svc donhangSvc)
        {
            _chiTietDonHangSvc = chiTietDonHangSvc;
            _donhangSvc = donhangSvc;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonHang>>> GetDonHang([FromQuery] int id)
        {
            var donhang= await _donhangSvc.GetDonHangAsync(id);
            List<DonHang> list = new List<DonHang>();
            list.Add(donhang);
            return list;
        }
    }
}
