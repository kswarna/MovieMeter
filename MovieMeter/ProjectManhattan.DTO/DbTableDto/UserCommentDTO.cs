
using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class UserCommentDTO
    {
        public string UserName { get; set; }
        public string Comment { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
