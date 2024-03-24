using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Business.Interfaces;

namespace WMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController : BaseController
    {
        private readonly ICalisanBs _calisanBs;

        public CalisanController(ICalisanBs calisanBs)
        {
            _calisanBs = calisanBs;
        }

        [HttpGet]
        public async Task<IActionResult> GetCalisanlar()
        {
            var response = await _calisanBs.GetCalisanlarAsync("Rol");
            return await SendResponseAsync(response);
        }
    }
}
