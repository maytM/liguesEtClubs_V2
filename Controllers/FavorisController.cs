using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class FavorisController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Favoris | Page";
            ViewBag.ActiveMenuItem = "Favoris";
            return View();
        }
    }
}
