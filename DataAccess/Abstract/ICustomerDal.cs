using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer, int>
    {
        // CRUD - Create, Read, Update, Delete
    }  
}
