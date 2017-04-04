using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;
using AutoMapper;

namespace ProjectManhattan.Repository
{
    public class UserRepository : GenericRepository<User, UserDTO>
    {
        public int InsertOrUpdateUser(UserDTO entityDTO)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var entity = dbContext.Set<User>().Find(entityDTO.UserId);
                if (entity != null)
                {
                    Mapper.Map(entityDTO, entity);
                    dbContext.SaveChanges();
                    return entity.UserId;
                }
                else
                {
                    var newEntity = Mapper.Map<User>(entityDTO);
                    dbContext.Set<User>().Add(newEntity);
                    dbContext.SaveChanges();
                    return newEntity.UserId;
                }
            }
        }
    }
}