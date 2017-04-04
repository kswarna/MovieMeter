using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public class GenericRepository<TEntity, TEntityDTO> : IRepository<TEntity, TEntityDTO> where TEntity : class where TEntityDTO : class 
    {
        public List<TEntityDTO> GetAllEntities()
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                return dbContext.Set<TEntity>().ToList().Select(m => Mapper.Map<TEntityDTO>(m)).ToList();
            }
        }

        public TEntityDTO GetEntity(int id)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var entity = dbContext.Set<TEntity>().Find(id);
                return entity != null ? Mapper.Map<TEntityDTO>(entity) : null;
            }
        }

        public void InsertOrUpdateEntity(int id, TEntityDTO entityDTO)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var entity = dbContext.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    Mapper.Map(entityDTO, entity);
                    dbContext.SaveChanges();
                }
                else
                {
                    var newEntity = Mapper.Map<TEntity>(entityDTO);
                    dbContext.Set<TEntity>().Add(newEntity);
                    dbContext.SaveChanges();
                    Mapper.Map(newEntity, entityDTO);
                }
            }
        }

        public void DeleteEntity(int id)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var entity = dbContext.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    dbContext.Set<TEntity>().Remove(entity);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
