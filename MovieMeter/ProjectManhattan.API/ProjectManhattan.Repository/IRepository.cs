using System.Collections.Generic;

namespace ProjectManhattan.Repository
{
    public interface IRepository<TEntity, TEntityDTO>
    {
        List<TEntityDTO> GetAllEntities();

        TEntityDTO GetEntity(int id);

        void InsertOrUpdateEntity(int id, TEntityDTO entityDTO);

        void DeleteEntity(int id);
        
    }
}
