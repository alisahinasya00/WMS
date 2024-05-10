using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WMS.MvcUI.Controllers;
using WMS.Presantation.Models;

namespace WMS.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLoginController : Controller
    {
        private readonly ILogger<AdminLoginController> _logger;

        public AdminLoginController(ILogger<AdminLoginController> logger)
        {
            _logger = logger;
        }


        public IActionResult AdminLogin()
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
