using CategoryTree_ProductManagement.BLL.Abstract.EntityServices;
using CategoryTree_ProductManagement.DAL.Abstract;
using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _dal;
        //başındaki alt tireyi farklı bir sınıfın nesnesi olduğunu belirtmek için kullanıyorum.
        public CategoryService(ICategoryDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Category entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Category Get(int entityId)
        {
            return _dal.Get(a => a.CategoryID == entityId);
        }

        public ICollection<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public void Insert(Category entity)
        {
            _dal.Add(entity);
        }

        public void Update(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
