using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using WMS.MvcUI.Areas.Admin.Models;
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

        public async Task<IActionResult> GetApi()
        {
            List<WMS.MvcUI.Areas.Admin.Models.Calisan> calisanList = null;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5002/api/Calisan"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<JObject>(apiResponse);
                    if (responseData != null)
                    {
                        calisanList = responseData["data"].ToObject<List<WMS.MvcUI.Areas.Admin.Models.Calisan>>();
                    }
                }
            }
            return View(calisanList);
        }




        public IActionResult AdminLogin()
        {
            return View();
        }
      /*  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
