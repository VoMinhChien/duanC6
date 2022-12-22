using AsmShare.Models;
using AsmShare.Services;
using Microsoft.AspNetCore.Mvc;

namespace AsmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnDetail : ControllerBase
    {

        private readonly IMonAnSvc _monAnSvc;
        public MonAnDetail(IMonAnSvc monAnSvc)
        {
            _monAnSvc = monAnSvc;
        }
        [HttpGet("{id}")]
        public MonAn GetMonAnsss( int id)
        {

            return _monAnSvc.GetMonAn(id);

        }
    }
}
