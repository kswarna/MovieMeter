using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace ProjectManhattanModel
{
    [MetadataType(typeof(MovieArtistMetaData))]
    public partial class MovieArtist
    {
        public override string ToString()
        {
            return string.Format("{0} - {1}", Movy.Name, Artist.ArtistName);
        }

        public class MovieArtistMetaData
        {

        }
    }



    public partial class MoviePhotoArtist
    {
        public override string ToString()
        {
            return string.Format("{0} - {1}", Artist.ArtistName, Path.GetFileName(MoviePhoto.MoviePhotoURL));
        }
    }
}
