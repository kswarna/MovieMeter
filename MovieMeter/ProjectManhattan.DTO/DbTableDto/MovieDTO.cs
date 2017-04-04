using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MovieDTO
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public bool HasReleased { get; set; }
        public int LanguageId { get; set; }

        public string SmallPictureString
        {
            get
            {
                return "data:image/png;base64," + Convert.ToBase64String(SmallPicture);
            }
        }

        public string LargePictureString
        {
            get { return "data:image/png;base64," + Convert.ToBase64String(LargePicture); }
        }

    }
}
