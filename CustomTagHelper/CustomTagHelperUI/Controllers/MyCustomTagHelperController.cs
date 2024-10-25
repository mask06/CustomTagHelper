using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelperUI.Controllers
{
    public class MyCustomTagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Giris(string kullaniciAdi)
        {
            if (kullaniciAdi == "admin")
            {
                ViewBag.Message = "hosgeldin";
                return View("Giris");
            }
            ViewBag.Message = "kullanci adı hatalı";
            return View("GirisYap");
        }
    }
}
