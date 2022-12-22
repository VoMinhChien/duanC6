using AsmShare.Models;
using AsmShare.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private readonly IMonAnSvc _monAnSvc;
        public MonAnController(IMonAnSvc monAnSvc)
        {
            _monAnSvc = monAnSvc;
        }
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<MonAn>>> GetMonAns(Phanloai id)
        //{

        //    return await _monAnSvc.GetMonAnAllAsync(id);
        //}
        public async Task<ActionResult<IEnumerable<MonAn>>> GetMonAns()
        {

            return await _monAnSvc.GetMonAnAllAsync();
            //show món ăn giao diện
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetMonAns(string search)
        {

            return await _monAnSvc.GetMonAnAllAsync(search);
            //show món ăn giao diện
        }
    }
}
