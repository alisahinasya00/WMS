using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Business.Interfaces;
using WMS.Model.Dtos.Calisan;

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

        [HttpGet("İsim")]
        public async Task<IActionResult> IsmeGoreGetir([FromQuery] string isim)
        {
            var response = await _calisanBs.IsimGoreCalisanGetirAsync(isim,"Rol");
            return await SendResponseAsync(response);
        }

        [HttpGet("Rol")]
        public async Task<IActionResult> RoleGoreGetir([FromQuery] int rol)
        {
            var response = await _calisanBs.RoleGoreCalisanGetirAsync(rol, "Rol");
            return await SendResponseAsync(response);
        }
    }
}
