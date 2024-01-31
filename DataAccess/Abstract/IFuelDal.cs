using Core.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IFuelDal : IEntityRepository<Fuel, int>
    {
        // CRUD - Create, Read, Update, Delete
    }
}