using System.Collections.Generic;
using ProjectManhattan.DTO.DbTableDTO;

namespace ProjectManhattan.DTO.AppScreenDTO.LikeComment
{
    public class LikeCommentPost
    {
        public UserDTO CurrentUser { get; set; }
        public string Comment;
        public List<int> SocialnetworkingSitesToBeUpdated { get; set; }
    }
}
