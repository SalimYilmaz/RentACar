using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : InMemoryEntityRepositoryBase<Car, int>, ICarDal
    {
        public IList<Car> GetListByBrand(int brandId)
        {
            IList<Car> carsByBrand = GetList()
                .Where(e => e.BrandId == brandId && e.DeletedAt == null)
                .ToList();

            return carsByBrand;
        }

        public IList<Car> GetListByCarState(string? carState)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByFuel(int fuelId)
        {
            IList<Car> carsByFuel = GetList()
                .Where(e => e.FuelId == fuelId && e.DeletedAt == null)
                .ToList();

            return carsByFuel;
        }

        public IList<Car> GetListByKilometer(int kilometer)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByModel(int modelId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByTransmission(int transmissionId)
        {
            IList<Car> carsByTransmission = GetList()
                .Where(e => e.TransmissionId == transmissionId && e.DeletedAt == null)
                .ToList();

            return carsByTransmission;
        }

        protected override int generateId()
        {
            throw new NotImplementedException();
        }
    }
}
