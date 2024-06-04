using System.Reflection;
using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnees m_baseDeDonnees { get; set; }

        public HomeController(BaseDeDonnees baseDeDonnees)
        {
            m_baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
           
            return View(m_baseDeDonnees.Ligues.ToList());
        }
    }
}
