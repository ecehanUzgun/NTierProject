using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        // Siparişler listelensin
        public IActionResult Index()
        {
            return View();
        }
    }
}
