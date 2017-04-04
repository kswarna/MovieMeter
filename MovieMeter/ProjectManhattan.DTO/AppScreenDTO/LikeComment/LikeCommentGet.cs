using System.Collections.Generic;
using ProjectManhattan.DTO.DbTableDTO;

namespace ProjectManhattan.DTO.AppScreenDTO.LikeComment
{
    public class LikeCommentGet
    {
        public UserDTO CurrentUser { get; set; }
        public List<UserCommentDTO> TopComments { get; set; }
        public List<UserCommentDTO> LatestComments { get; set; }
    }
}
