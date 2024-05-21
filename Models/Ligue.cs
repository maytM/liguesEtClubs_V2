namespace liguesEtClubs_V2.Models
{
    public class Ligue
    {
        public int LigueID { get; set; }
        public string? Nom { get; set; }
        public string? Pays { get; set; }
        public string? Description { get; set;}
        public string? Image { get; set; }
        public int AnneeCreation { get; set; }
        public string? SiteWeb { get; set; }
        public int NombresDeClubs { get; set; }

    }
}
