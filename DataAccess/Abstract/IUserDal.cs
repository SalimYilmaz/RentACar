using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User, int>
    {
        // CRUD - Create, Read, Update, Delete
    }
}
