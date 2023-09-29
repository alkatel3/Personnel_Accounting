using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Interfaces
{
    public interface IRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void UpDate(TEntity item);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
