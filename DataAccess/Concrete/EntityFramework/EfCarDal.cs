using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }


        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
   

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }



        public Car? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetList()
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