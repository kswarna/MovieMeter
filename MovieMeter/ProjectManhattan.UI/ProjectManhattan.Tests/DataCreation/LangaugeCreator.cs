using System.Collections.Generic;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class LangaugeCreator
    {
        public static List<Language> GetAll()
        {
            var languages = new List<Language>();
            var telugu = new Language
            {
                LanguageID = 1,
                LanguageName = "Telugu"
            };
            languages.Add(telugu);
            var tamil = new Language
            {
                LanguageID = 15,
                LanguageName = "Tamil"
            };
            languages.Add(tamil);
            var hindi = new Language
            {
                LanguageID = 18,
                LanguageName = "Hindi"
            };
            languages.Add(hindi);

            return languages;
        }

        public static Language CreateLanguage(int id, string name)
        {
            return new Language {LanguageID = id, LanguageName = name};
        }
    }
}
