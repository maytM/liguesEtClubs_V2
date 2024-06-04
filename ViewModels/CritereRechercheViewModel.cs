namespace liguesEtClubs_V2.ViewModels
{
    public class CritereRechercheViewModel
    {
        public string? choixPourClubVedette { get; set; }
        public bool EstClubPremierLigue { get; set; }
        public bool EstClubLiga { get; set; }
        public bool EstClubLigue1 { get; set; }
        public int? MaxTitreAuChampionat { get; set; }
        public int? MinTitreAuChampionat { get; set; }
        public string? MotsCles { get; set; }
    }
}
