using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManhattan
{
    public partial class CriticSite
    {
        public CriticSite Copy(int id)
        {
            return new CriticSite()
            {
                CriticSiteId = CriticSiteId,
                SiteName = SiteName,
                WebUrl = WebUrl,
                AlexaRating = AlexaRating
            };
        }

        public DTO.CriticSite CriticSiteDto()
        {
            return new DTO.CriticSite()
            {
                CriticSiteId = CriticSiteId,
                SiteName = SiteName,
                WebUrl = WebUrl,
                AlexaRating = AlexaRating
            };
        }

        public static IEnumerable<DTO.CriticSite> CriticSiteLsitDto(IEnumerable<CriticSite> criticSites)
        {
            return criticSites.Select(criticSite => criticSite.CriticSiteDto());
        }

    }
}