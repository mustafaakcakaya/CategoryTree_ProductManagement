using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.BLL.Abstract
{
    public interface IBaseService<T>
        where T : IEntity
    {
        void Insert(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void Update(T entity);
        T Get(int entityId);

        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
