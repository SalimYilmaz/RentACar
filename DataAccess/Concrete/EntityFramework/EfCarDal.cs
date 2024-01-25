using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public Car Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Delete(Car entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Car? Get(Func<Car, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetList(Func<Car, bool>? predicate = null)
        {
            throw new NotImplementedException();
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
