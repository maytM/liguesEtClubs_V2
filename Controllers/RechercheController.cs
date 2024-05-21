using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class RechercheController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Recherche | Page";
            ViewBag.ActiveMenuItem = "Recherche";

            var baseDeDonnees = new BaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListClubs();

            return View(donnees);
        }
        public IActionResult ClubsLigue(int id)
        {
            ViewBag.ActiveMenuItem = "Recherche";

            var baseDeDonnees = new BaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListClubs();

            var ClubsFiltrés = new List<Club>();

            foreach (Club element in donnees)
            {
                if (id == element.Ligue.LigueID)
                {
                    ClubsFiltrés.Add(element);
                }
            }

            if (ClubsFiltrés.Count>0)
            {
                return View(ClubsFiltrés);
            }

            return NotFound();
        }


        public IActionResult Detail(int id)
        {
            var baseDeDonnees = new BaseDeDonnees();

            var donnees = baseDeDonnees.ObtenirListClubs();
         
            foreach (Club element in donnees)
            {
                if (id == element.ClubID)
                {
                    return View(element);
                }
            }
            return NotFound();
        }
    }
}
