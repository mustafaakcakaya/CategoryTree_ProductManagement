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
    public class UserService : IUserService
    {
        IUserDAL _dal;
        //başındaki alt tireyi farklı bir sınıfın nesnesi olduğunu belirtmek için kullanıyorum.
        public UserService(IUserDAL dal)
        {
            _dal = dal;
        }
        public void Delete(User entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public User Get(int entityId)
        {
            return _dal.Get(a => a.UserID == entityId);
        }

        public ICollection<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public void Insert(User entity)
        {
            _dal.Add(entity);
        }

        public void Update(User entity)
        {
            _dal.Update(entity);
        }
    }
}
