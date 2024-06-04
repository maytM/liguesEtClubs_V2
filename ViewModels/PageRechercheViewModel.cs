using liguesEtClubs_V2.Models;

namespace liguesEtClubs_V2.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel?  Criteres { get; set; }
        public List<Club>? Resultat { get; set; }
    }
}
