namespace liguesEtClubs_V2.Models
{
    public class Club
    {
        public int ClubID { get; set; }
        public string? Nom { get; set; }
        public string? Ville { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int AnneeCreation { get; set; }
        public string? Stade { get; set; }
        public int CapaciteStade { get; set; }
        public string? Surnom { get; set; }
        public bool EstElementVedette { get; set; }
        public int LigueID { get; set; }
        public Ligue? Ligue { get; set; }

    }
}
