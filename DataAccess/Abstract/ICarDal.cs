using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car, int>
    {
        // CRUD - Create, Read, Update, Delete
    }
}
