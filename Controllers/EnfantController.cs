using liguesEtClubs_V2.Models;
using liguesEtClubs_V2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace liguesEtClubs_V2.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnees m_baseDeDonnees { get; set; }

        public EnfantController(BaseDeDonnees baseDeDonnees)
        {
            m_baseDeDonnees = baseDeDonnees;
        }

        [Route("enfant/Recherche/{id?}")]
        public IActionResult Recherche(int? id)
        {

            var model = new PageRechercheViewModel();

            model.Criteres = new CritereRechercheViewModel();

            model.Criteres.MotsCles = "Real Madrid";
            model.Criteres.choixPourClubVedette = null;

            model.Criteres.EstClubPremierLigue = false;
            model.Criteres.EstClubLiga = true;
            model.Criteres.EstClubLigue1 = false;

            model.Criteres.MinTitreAuChampionat = 1;
            model.Criteres.MaxTitreAuChampionat = 36;

            if (id==null)
            {
                model.Resultat = m_baseDeDonnees.Clubs.ToList();
            }
            else
            {
                model.Resultat = m_baseDeDonnees.Clubs.Where(c => c.LigueID == id).ToList();
            }
            
            return View(model);
        }

        [Route("enfant/detail/{id:int}")]
        [Route("enfant/{id:int}")]
        [Route("{id:int}")]
        public IActionResult DetailParID(int id)
        {           
            var clubRecherché = m_baseDeDonnees.Clubs.Where(c => c.ClubID == id).SingleOrDefault();

            if (clubRecherché == null)
            {
                return View("NotFound", "Le numéro du club n'a pas été trouvé!");
            }
            else
            {
                return View("Detail",clubRecherché);
            }

        }

        [Route("enfant/detail/{nom}")]
        [Route("enfant/{nom}")]
        [Route("{nom}")]
        public IActionResult DetailParNom(string nom)
        {   
            
            var clubRecherché = m_baseDeDonnees.Clubs.Where(c => c.Nom.ToLower() == nom.ToLower()).SingleOrDefault();

            if (clubRecherché == null)
            {
             
                return View("NotFound", "Le nom du club n'a pas été trouvé!");

            }
            else
            {
                return View("Detail", clubRecherché);
            }

        }

        [Route("enfant/RechercheClub")]
        public IActionResult RechercheClub(
            string? MotsCles , 
            int? MinTitreAuChampionat,
            int? MaxTitreAuChampionat, 
            string? choixPourClubVedette, 
            string? EstClubPremierLigue,
            string? EstClubLiga,
            string? EstClubLigue1 )
        {


            var model = new PageRechercheViewModel();

            model.Criteres = new CritereRechercheViewModel();

            model.Criteres.MotsCles = MotsCles;
            model.Criteres.choixPourClubVedette = choixPourClubVedette;

            model.Criteres.EstClubPremierLigue = EstClubPremierLigue=="on"?true:false;
            model.Criteres.EstClubLiga = EstClubLiga == "on" ? true : false;
            model.Criteres.EstClubLigue1 = EstClubLigue1 == "on" ? true : false;

            model.Criteres.MinTitreAuChampionat = MinTitreAuChampionat;
            model.Criteres.MaxTitreAuChampionat = MaxTitreAuChampionat;


            List<Club> clubsFiltrés = m_baseDeDonnees.Clubs;

            /// Filtré par choixPourClubVedette
            /// 
            if (choixPourClubVedette != null)
            {

                clubsFiltrés = choixPourClubVedette=="Oui"? clubsFiltrés.Where(c => c.EstElementVedette==true).ToList() : clubsFiltrés.Where(c => c.EstElementVedette == false).ToList();
            }

            /// Filtré par MotsCles
            /// 
            if (MotsCles != null)
            {
                int id = 0;

                string nom = MotsCles.ToLower();

                bool conversionTermeEnInt = int.TryParse(MotsCles, out id);

                clubsFiltrés = clubsFiltrés.Where(c => (c.Nom.ToLower().Contains(nom) || c.ClubID == id)).ToList();
            }


            ///Filtré par  EstClubPremierLigue , EstClubLiga ou EstClubLigue1
            /// 
            if (EstClubPremierLigue == "on" && EstClubLiga == "on" && EstClubLigue1 == "on")
            {
                clubsFiltrés = clubsFiltrés.Select(c => c).ToList(); 

            }
            if (EstClubPremierLigue != "on" && EstClubLiga != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID == 3).ToList();

            } 
            
            if (EstClubPremierLigue != "on" && EstClubLigue1 != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID == 2).ToList();

            } 
            
            if (EstClubLiga != "on" && EstClubLigue1 != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID == 1).ToList();

            }
            
            if (EstClubPremierLigue != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID != 1).ToList();
            }
            
            if (EstClubLiga != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID != 2).ToList();
            }
            
            if (EstClubLigue1 != "on")
            {
                clubsFiltrés = clubsFiltrés.Where(c => c.Ligue.LigueID != 3).ToList();
            }

            ///Filtré par  MinTitreAuChampionat et MaxTitreAuChampionat
            ///
            if (MinTitreAuChampionat !=null && MaxTitreAuChampionat !=null)
            {
                if (MinTitreAuChampionat <= MaxTitreAuChampionat)
                {
                    clubsFiltrés = clubsFiltrés.Where(c => (c.NombreTitreAuChampionat >= MinTitreAuChampionat) && (c.NombreTitreAuChampionat <= MaxTitreAuChampionat) ).ToList();
                }
            }

            /// Filtre final
            /// 
            model.Resultat = clubsFiltrés;


            /// retourné le model a la vue recherche
            return View("Recherche", model);
        }
    }
}
