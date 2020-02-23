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
    public class ProductService : IProductService
    {
        IProductDAL _dal;
        //başındaki alt tireyi farklı bir sınıfın nesnesi olduğunu belirtmek için kullanıyorum.
        public ProductService(IProductDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Product Get(int entityId)
        {
            return _dal.Get(a => a.ProductID == entityId);
        }

        public ICollection<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public void Insert(Product entity)
        {
            _dal.Add(entity);
        }

        public void Update(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
