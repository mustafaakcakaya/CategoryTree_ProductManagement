using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Core.DataAccess
{
    //Database bağlantılarımda sadece IEntity implementini barındıran Entity'lerimin kullanılmasını ve bunlar için taslak oluşturma niteliğindeki interface'imi CRUD işlemlerimle birlikte tanımladığım kısım
    public interface IEntityRepository<TEntity>
        where TEntity : IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}
