using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Accueil | Page";
            ViewBag.ActiveMenuItem = "Home";

            var baseDeDonnees = new BaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListLigues();

            return View(donnees);
        }
    }
}
