using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class EnfantController : Controller
    {
        
        public IActionResult Recherche(int id=15)
        {
            ViewBag.ActiveMenuItem = "Recherche";

            var baseDeDonnees = new BaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListClubs();

            var ClubsFiltrés = new List<Club>();


            if (id==15)
            {
                ClubsFiltrés = donnees;
            }
            else
            {
                foreach (Club element in donnees)
                {
                    if (id == element.Ligue.LigueID)
                    {
                        ClubsFiltrés.Add(element);
                    }
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
