using Core.DataAccess;
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

        public void Update(Model entity)
        {
            throw new NotImplementedException();
        }

        public Model Delete(Model entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Model? Get(Func<Model, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetList(Func<Model, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }        

        Model IEntityRepository<Model, int>.Add(Model entity)
        {
            throw new NotImplementedException();
        }

        Model IEntityRepository<Model, int>.Update(Model entity)
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