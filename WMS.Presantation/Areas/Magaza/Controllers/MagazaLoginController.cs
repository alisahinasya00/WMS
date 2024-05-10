using Microsoft.AspNetCore.Mvc;

namespace WMS.MvcUI.Areas.Magaza.Controllers
{
    public class MagazaLoginController : Controller
    {
        [Area("Magaza")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
