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
    public class ErrorService : IErrorService
    {
        IErrorDAL _dal;
        //başındaki alt tireyi farklı bir sınıfın nesnesi olduğunu belirtmek için kullanıyorum.
        public ErrorService(IErrorDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Error entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Error Get(int entityId)
        {
            return _dal.Get(a => a.ErrorID == entityId);
        }

        public ICollection<Error> GetAll(Expression<Func<Error, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public void Insert(Error entity)
        {
            _dal.Add(entity);
        }

        public void Update(Error entity)
        {
            _dal.Update(entity);
        }
    }
}
