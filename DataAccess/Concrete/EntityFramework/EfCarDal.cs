using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, int, RentACarContext>, ICarDal
    {
        public EfCarDal(RentACarContext context) : base(context)
        {

        }
    
        public IList<Car> GetListByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByFuel(int fuelId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByTransmission(int transmissionId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByCarState(string? carState)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByKilometer(int kilometer)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetListByModel(int modelId)
        {
            throw new NotImplementedException();
        }

    }
}