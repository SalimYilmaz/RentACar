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
    public class EfFuelDal : IFuelDal
    {
        public void Add(Fuel entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Fuel entity)
        {
            throw new NotImplementedException();
        }

        public Fuel Delete(Fuel entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Fuel? Get(Func<Fuel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Fuel> GetList(Func<Fuel, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        Fuel IEntityRepository<Fuel, int>.Add(Fuel entity)
        {
            throw new NotImplementedException();
        }

        Fuel IEntityRepository<Fuel, int>.Update(Fuel entity)
        {
            throw new NotImplementedException();
        }
    }
}