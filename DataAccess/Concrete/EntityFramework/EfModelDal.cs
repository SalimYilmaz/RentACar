using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfModelDal : IModelDal
    {
        public void Add(Model entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Model entity)
        {
            throw new NotImplementedException();
        }

        public Model? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetList()
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetListByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetListByFuel(int fuelId)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetListByTransmission(int transmissionId)
        {
            throw new NotImplementedException();
        }

    }
}