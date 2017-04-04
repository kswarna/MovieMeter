using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManhattanModel
{
    /// <summary>
    /// Summary description for Movy
    /// </summary>
    [MetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {

        public class MovieMetaData
        {
            [ScaffoldColumn(true)]
            [UIHint("Image")]
            public byte[] SmallPicture { get; set; }

            [ScaffoldColumn(true)]
            [UIHint("Image")]
            public byte[] LargePicture { get; set; }
            
        }

        public string DisplayName
        {
            get { return string.Format("{0} -- {1}", Name, Language.LanguageName); }
        }
    }
}
