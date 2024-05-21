namespace liguesEtClubs_V2.Models
{
    public class BaseDeDonnees
    {
        // Retourne une liste des ligues
        public List<Ligue> ObtenirListLigues()
        {
        
        var Ligues = new List<Ligue>();
            Ligues.Add(new Ligue()
            {
                LigueID = 1,
                Nom = "Premier League",
                Pays = "Angleterre",
                Description = "Depuis son inauguration en 1992, la Premier League a évolué pour devenir le sommet du football en Angleterre, attirant une attention mondiale avec ses clubs de renommée internationale, ses joueurs talentueux et son niveau de compétition exceptionnel.",
                Image= "/images/premierLigue2.png",
                AnneeCreation = 1992,
                SiteWeb = "https://www.premierleague.com/",
                NombresDeClubs = 20
            });

            Ligues.Add(new Ligue()
            {
                LigueID = 2,
                Nom = "LaLiga",
                Pays = "Espagne",
                Description = "La Liga, lancée en 1929, est devenue l'un des sommets du football en Espagne. Elle attire une attention mondiale grâce à ses clubs renommés, ses joueurs talentueux et son niveau de compétition exceptionnel.",
                Image = "/images/liga.png",
                AnneeCreation = 1929,
                SiteWeb = "https://www.laliga.com/",
                NombresDeClubs = 20
            });
            
            Ligues.Add(new Ligue()
            {
                LigueID = 3,
                Nom = "Ligue 1",
                Pays = "France",
                Description = "La Ligue 1 est le championnat professionnel de football masculin de plus haut niveau de la Fédération française de football. Il regroupe les meilleurs clubs de France métropolitaine et de Monaco.",
                Image = "/images/ligue1.png",
                AnneeCreation = 1932,
                SiteWeb = " https://www.ligue1.fr/",
                NombresDeClubs = 20
            });

            return Ligues;
        }


        // Retourne une liste des clubs

        public List<Club> ObtenirListClubs()
        {
            var Clubs = new List<Club>();

            // Clubs premier League
            Clubs.Add(new Club()
            {
                ClubID = 1,
                Nom = "Manchester City",
                Ville = "Manchester",
                Description = "Manchester City Football Club est un club de football anglais basé à Manchester, fondé en 1880 sous le nom de St. Mark's (West Gorton). Il devint le Ardwick Association Football Club en 1887 avant de prendre son nom actuel en 1894. Le club participe à la Premier League, le championnat anglais de football, qu'il a remporté plusieurs fois.",
                Image = "/images/manCity.png",
                AnneeCreation = 1880,
                Stade = "Etihad Stadium",
                CapaciteStade = 55097,
                Surnom= "Les Citizens",
                EstElementVedette = true,
                Ligue= ObtenirListLigues()[0]
            });

            Clubs.Add(new Club()
            {
                ClubID = 2,
                Nom = "Liverpool",
                Ville = "Liverpool",
                Description = "Liverpool Football Club est un club de football professionnel anglais basé à Liverpool. Fondé en 1892, il évolue au stade d'Anfield depuis sa création. Liverpool a remporté de nombreux titres nationaux et internationaux au fil des ans, y compris la Premier League, la Ligue des champions de l'UEFA, la Coupe UEFA, la Coupe de la Ligue, la FA Cup et la Supercoupe de l'UEFA.",
                Image = "/images/liverpool2.jpg",
                AnneeCreation = 1892,
                Stade = "Anfield",
                CapaciteStade = 54074,
                Surnom = "Les Reds",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[0]
            });

            Clubs.Add(new Club()
            {
                ClubID = 3,
                Nom = "Manchester United",
                Ville = "Manchester",
                Description = "Manchester United Football Club est un club de football professionnel anglais basé à Old Trafford, dans le Grand Manchester. Fondé en 1878 en tant que Newton Heath LYR Football Club, Manchester United a remporté de nombreux titres nationaux et internationaux, y compris la Premier League, la Ligue des champions de l'UEFA, la Coupe UEFA, la Coupe de la Ligue, la FA Cup et la Supercoupe de l'UEFA.",
                Image = "/images/manUnited.png",
                AnneeCreation = 1878,
                Stade = "Old Trafford",
                CapaciteStade = 74691,
                Surnom = "Les Red Devils",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[0]
            });

            Clubs.Add(new Club()
            {
                ClubID = 4,
                Nom = "Chelsea",
                Ville = "Londres",
                Description = "Chelsea Football Club est un club de football professionnel anglais basé à Fulham, Londres. Fondé en 1905, Chelsea a remporté de nombreux titres nationaux et internationaux au fil des ans, y compris la Premier League, la Ligue des champions de l'UEFA, la Coupe UEFA, la Coupe de la Ligue, la FA Cup et la Supercoupe de l'UEFA.",
                Image = "/images/chealse.png",
                AnneeCreation = 1905,
                Stade = "Stamford Bridge",
                CapaciteStade = 40834,
                Surnom = "Les Blues",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[0]
            });

            Clubs.Add(new Club()
            {
                ClubID = 5,
                Nom = "Arsenal",
                Ville = "Londres",
                Description = "Arsenal Football Club est un club de football professionnel anglais basé à Holloway, Londres. Fondé en 1886, Arsenal a remporté de nombreux titres nationaux et internationaux au fil des ans, y compris la Premier League, la Ligue des champions de l'UEFA, la Coupe UEFA, la Coupe de la Ligue, la FA Cup et la Supercoupe de l'UEFA.",
                Image = "/images/arsenal.png",
                AnneeCreation = 1886,
                Stade = "Emirates Stadium",
                CapaciteStade = 60260,
                Surnom = "Les Gunners",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[0]
            });

            // Clubs LaLiga

            Clubs.Add(new Club()
            {
                ClubID = 6,
                Nom = "Real Madrid",
                Ville = "Madrid",
                Description = "Real Madrid Club de Fútbol est un club de football professionnel espagnol basé à Madrid. Fondé en 1902, le Real Madrid est l'un des clubs de football les plus titrés au monde, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Liga, la Ligue des champions de l'UEFA, la Coupe UEFA, la Supercoupe de l'UEFA, la Coupe intercontinentale et la Coupe du monde des clubs de la FIFA.",
                Image = "/images/Logo_Real_Madrid.svg.png",
                AnneeCreation = 1902,
                Stade = "Santiago Bernabéu",
                CapaciteStade = 81044,
                Surnom = "Les Merengues",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[1]
            });

            Clubs.Add(new Club()
            {
                ClubID = 7,
                Nom = "FC Barcelone",
                Ville = "Barcelone",
                Description = "Futbol Club Barcelona, communément appelé FC Barcelone ou Barça, est un club de football professionnel espagnol basé à Barcelone, en Catalogne. Fondé en 1899, le FC Barcelone est l'un des clubs les plus populaires et les plus titrés au monde, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Liga, la Ligue des champions de l'UEFA, la Coupe UEFA, la Supercoupe de l'UEFA, la Coupe intercontinentale et la Coupe du monde des clubs de la FIFA.",
                Image = "/images/barca.png",
                AnneeCreation = 1899,
                Stade = "Camp Nou",
                CapaciteStade = 99354,
                Surnom = "Les Blaugranas",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[1]
            });

            Clubs.Add(new Club()
            {
                ClubID = 8,
                Nom = "Atletico Madrid",
                Ville = "Madrid",
                Description = "Club Atlético de Madrid, communément appelé Atlético Madrid, est un club de football professionnel espagnol basé à Madrid. Fondé en 1903, l'Atlético Madrid est l'un des clubs les plus titrés en Espagne, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Liga, la Coupe du Roi, la Ligue Europa de l'UEFA, la Supercoupe de l'UEFA et la Coupe intercontinentale.",
                Image = "/images/atlético.png",
                AnneeCreation = 1903,
                Stade = "Wanda Metropolitano",
                CapaciteStade = 68224,
                Surnom = "Les Colchoneros",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[1]
            });

            Clubs.Add(new Club()
            {
                ClubID = 9,
                Nom = "Valencia CF",
                Ville = "Valence",
                Description = "Valencia Club de Fútbol est un club de football professionnel espagnol basé à Valence, dans la Communauté valencienne. Fondé en 1919, Valence CF est l'un des clubs les plus populaires et les plus titrés en Espagne, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Liga, la Coupe du Roi, la Ligue Europa de l'UEFA, la Supercoupe de l'UEFA et la Coupe intercontinentale.",
                Image = "/images/valencia.png",
                AnneeCreation = 1919,
                Stade = "Mestalla",
                CapaciteStade = 48655,
                Surnom = "Les Chés",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[1]
            });

            Clubs.Add(new Club()
            {
                ClubID = 10,
                Nom = "Sevilla FC",
                Ville = "Séville",
                Description = "Sevilla Fútbol Club est un club de football professionnel espagnol basé à Séville, en Andalousie. Fondé en 1890, le Sevilla FC est l'un des clubs les plus titrés en Espagne, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Liga, la Coupe du Roi, la Ligue Europa de l'UEFA et la Supercoupe de l'UEFA.",
                Image = "/images/sevilla.png",
                AnneeCreation = 1890,
                Stade = "Ramón Sánchez Pizjuán",
                CapaciteStade = 43700,
                Surnom = "Les Sévillans",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[1]
            });

            // Club Ligue 1

            Clubs.Add(new Club()
            {
                ClubID = 11,
                Nom = "Paris Saint-Germain",
                Ville = "Paris",
                Description = "Paris Saint-Germain Football Club, communément appelé PSG, est un club de football professionnel français basé à Paris. Fondé en 1970, le Paris Saint-Germain est l'un des clubs les plus titrés en France, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Ligue 1, la Coupe de France, la Coupe de la Ligue et la Supercoupe de France.",
                Image = "/images/psg.png",
                AnneeCreation = 1970,
                Stade = "Parc des Princes",
                CapaciteStade = 47929,
                Surnom = "Les Parisiens",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[2]
            });

            Clubs.Add(new Club()
            {
                ClubID = 12,
                Nom = "Olympique de Marseille",
                Ville = "Marseille",
                Description = "Olympique de Marseille, communément appelé OM, est un club de football professionnel français basé à Marseille. Fondé en 1899, l'Olympique de Marseille est l'un des clubs les plus populaires et les plus titrés en France, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Ligue 1, la Coupe de France et la Ligue Europa de l'UEFA.",
                Image = "/images/marseille.jpeg",
                AnneeCreation = 1899,
                Stade = "Stade Vélodrome",
                CapaciteStade = 67881,
                Surnom = "Les Phocéens",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[2]
            });

            Clubs.Add(new Club()
            {
                ClubID = 13,
                Nom = "AS Monaco",
                Ville = "Monaco",
                Description = "Association Sportive de Monaco Football Club, communément appelé AS Monaco, est un club de football professionnel monégasque basé à Monaco. Fondé en 1924, l'AS Monaco est l'un des clubs les plus titrés en France, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Ligue 1, la Coupe de France et la Supercoupe de France.",
                Image = "/images/monaco.png",
                AnneeCreation = 1924,
                Stade = "Stade Louis II",
                CapaciteStade = 18523,
                Surnom = "Les Monégasques",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[2]
            });

            Clubs.Add(new Club()
            {
                ClubID = 14,
                Nom = "Olympique Lyonnais",
                Ville = "Lyon",
                Description = "Olympique Lyonnais, communément appelé OL, est un club de football professionnel français basé à Lyon. Fondé en 1950, l'Olympique Lyonnais est l'un des clubs les plus titrés en France, avec un palmarès impressionnant comprenant de nombreux titres nationaux et internationaux, y compris la Ligue 1, la Coupe de France et la Coupe de la Ligue.",
                Image = "/images/Olympique_Lyonnais.png",
                AnneeCreation = 1950,
                Stade = "Groupama Stadium",
                CapaciteStade = 59186,
                Surnom = "Les Gones",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[2]
            });

            Clubs.Add(new Club()
            {
                ClubID =15,
                Nom = "Stade Rennais FC",
                Ville = "Rennes",
                Description = "Stade Rennais Football Club, communément appelé Rennes, est un club de football professionnel français basé à Rennes. Fondé en 1901, le Stade Rennais est l'un des clubs les plus anciens en France, avec un palmarès impressionnant comprenant plusieurs participations en Ligue Europa et en Coupe de la Ligue.",
                Image = "/images/stadeRennais.png",
                AnneeCreation = 1901,
                Stade = "Roazhon Park",
                CapaciteStade = 29384,
                Surnom = "Les Rennais",
                EstElementVedette = true,
                Ligue = ObtenirListLigues()[2]
            });

            return Clubs;
        }

    }
}
