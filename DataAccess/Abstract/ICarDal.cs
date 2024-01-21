using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car, int>
    {
        // CRUD Operations
        IList<Car> GetListByBrand(int brandId);
        IList<Car> GetListByCarState(string? carState);
        IList<Car> GetListByColor(int colorId);
        IList<Car> GetListByFuel(int fuelId);
        IList<Car> GetListByKilometer(int kilometer);
        IList<Car> GetListByModel(int modelId);
        IList<Car> GetListByTransmission(int transmissionId);
    }
}
