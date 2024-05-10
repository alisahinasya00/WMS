using Microsoft.AspNetCore.Mvc;

namespace WMS.MvcUI.Areas.Calisan.Controllers
{
    public class CalisanLoginController : Controller
    {
        [Area("Calisan")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
