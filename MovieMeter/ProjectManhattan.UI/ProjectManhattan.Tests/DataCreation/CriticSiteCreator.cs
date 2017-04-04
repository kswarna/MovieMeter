using System.Collections.Generic;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class WebSiteCreator
    {
        public static List<CriticSite> GetAllCriticSites()
        {
            return new List<CriticSite>
            {
                CreateSite(1, "GreatAndhra", "www.GreatAndhra.com", 1),
                CreateSite(2, "Idlebrain", "www.Idlebrain.com", 2),
                CreateSite(3, "Tupaki", "www.Tupaki.com", 3),
                CreateSite(4, "Gulte", "www.Gulte.com", 4),
                CreateSite(5, "123Telugu", "www.123Telugu.com", 5),
                CreateSite(6, "CineJosh", "www.CineJosh.com", 6),
                CreateSite(7, "Filmibeat", "www.Filmibeat.com", 7),
                CreateSite(8, "TeluguCinema", "www.TeluguCinema.com", 8),
                CreateSite(9, "Chitramala", "www.Chitramala.com", 9)
            };
        }

        public static CriticSite CreateSite(int id, string name, string url, int alexaRating)
        {
            return new CriticSite {CriticSiteId = id,AlexaRating = alexaRating,SiteName = name,WebUrl = url};
        }
    }
}
