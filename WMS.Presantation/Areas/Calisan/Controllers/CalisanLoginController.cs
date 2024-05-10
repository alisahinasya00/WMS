using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WMS.MvcUI.Areas.Admin.Controllers;
using WMS.Presantation.Models;

namespace WMS.MvcUI.Areas.Calisan.Controllers
{
    [Area("Calisan")]
    public class CalisanLoginController : Controller
    {
        private readonly ILogger<CalisanLoginController> _logger;

        public CalisanLoginController(ILogger<CalisanLoginController> logger)
        {
            _logger=logger;
        }
        public IActionResult CalisanLogin()
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
