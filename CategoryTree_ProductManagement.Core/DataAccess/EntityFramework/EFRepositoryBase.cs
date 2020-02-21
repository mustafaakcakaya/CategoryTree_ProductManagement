using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Core.DataAccess.EntityFramework
{
    /*Bu sınıfı yapılacak bütün CRUD işlemlerini Data Access Layer'da her yere aynı şeyleri yazmamak(yani clean code'u sağlayarak karmaşıklığı en aza indirmek) 
     ve değiştirmek istediğimde tek kanalda ulaşabilmeyi sağlamak(yani maintainability'yi arttırmak) için kullandım.*/
    class EFRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext tContext;
        public EFRepositoryBase()
        {
            tContext = new TContext();
        }
        public void Add(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Added;
            tContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Deleted;
            tContext.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //tek entity istediğimden single or default u kullandım.
            //First of Default'a göre biraz daha yavaştır ama sorgu sonucumun tek entity olduğunu garantiler.
            return tContext.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)//filtresiz de çalışabilmesi için Expression filtresine default olarak null atadım.
        {
            if (filter == null)
            {
                return tContext.Set<TEntity>().ToList();
            }
            else
            {
                return tContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Modified;
            tContext.SaveChanges();
        }
    }
}
