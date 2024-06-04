using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class FavorisController : Controller
    {
        private BaseDeDonnees m_baseDeDonnees { get; set; }

        public FavorisController(BaseDeDonnees baseDeDonnees)
        {
            m_baseDeDonnees = baseDeDonnees;
        }
        public IActionResult Index()
        {
           // @ViewData["id"] = id;

            return View(m_baseDeDonnees.Favoris.ToList());
        }

        [Route("Favoris/Ajouter")]
        public IActionResult Ajouter(int id)
        {
            //@ViewData["id"] = id;

            var favoris = m_baseDeDonnees.Favoris;

            Club favorisExist= favoris.Where(f=>f.ClubID==id).SingleOrDefault();

            Club favorisAAjouter= m_baseDeDonnees.Clubs.Where(c=>c.ClubID==id).SingleOrDefault();

            if (favorisExist == null)
            {
                favoris.Add(favorisAAjouter);
            }

            return View("Index",favoris);
        }
        [Route("Favoris/Supprimer")]
        public IActionResult Supprimer(int id)
        {
            @ViewData["id"] = id;

            var favoris = m_baseDeDonnees.Favoris;

            for (int i= favoris.Count-1; i>=0; i--)
            {
                if (favoris[i].ClubID==id)
                {
                    favoris.RemoveAt(i);

                    break;
                }
            }

            return View("Index",favoris);
        }
    }
}
