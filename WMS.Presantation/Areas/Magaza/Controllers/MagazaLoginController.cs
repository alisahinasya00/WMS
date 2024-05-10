using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WMS.MvcUI.Areas.Admin.Controllers;
using WMS.Presantation.Models;

namespace WMS.MvcUI.Areas.Magaza.Controllers
{
    [Area("Magaza")]
    public class MagazaLoginController : Controller
    {
        private readonly ILogger<MagazaLoginController> _logger;

        public MagazaLoginController(ILogger<MagazaLoginController> logger)
        {
            _logger= logger;
        }
        public IActionResult MagazaLogin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
