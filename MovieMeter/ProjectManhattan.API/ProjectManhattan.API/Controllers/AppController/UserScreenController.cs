using System.Web.Http;
using System.Web.Http.Description;
using ProjectManhattan.Repository;
using ProjectManhattan.DTO.DbTableDTO;

namespace ProjectManhattan.Controllers.AppController
{
    public class UserScreenController : ApiController
    {
        UserRepository _userPreferenece = new UserRepository();
        [ResponseType(typeof(UserDTO))]
        public UserDTO Get(int userId)
        {
            return _userPreferenece.GetEntity(userId); ;
        }

        [HttpPost]
        public int CreateUser(UserDTO User)
        {
           // UserDTO User = new UserDTO { UserName = userName, Password = password, LanguageId = languageId };
           return  _userPreferenece.InsertOrUpdateUser(User);
        }
    }
}
