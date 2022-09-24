using Microsoft.AspNetCore.Mvc;

namespace ViewsAndRazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult CarpimTablosu()
        {
            // Not : eğer view metoduna parametre ile viewname belirtmezsek action name isimli view dosyasını arar...
            return View("Sonuc");
        }
    }
}