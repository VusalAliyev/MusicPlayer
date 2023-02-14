using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task <IEnumerable<TEntity>> GetAll();
        Task Remove(TEntity entity);
        Task<TEntity> Find(int id);
    }
}
