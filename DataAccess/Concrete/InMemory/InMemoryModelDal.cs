using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryModelDal : InMemoryEntityRepositoryBase<Model, int>, IModelDal
    {

        // InMemoryEntityRepositoryBase Class'ında generateId metodu abstract idi. Tanımlamamızı istedi. Tanımladık.
        protected override int generateId()
        {
            int nextId = Entities.Count == 0 ? 1 : Entities.Max(e => e.Id) + 1;
            return nextId;
        }


       
        /*
         
        public IList<Model> GetListByBrand(int brandId)
        {
            IList<Model> modelsByBrand = GetList()
                .Where(e => e.BrandId == brandId && e.DeletedAt == null)
                .ToList();

            return modelsByBrand;
        }

        public IList<Model> GetListByFuel(int fuelID)
        {
            IList<Model> modelsByFuel = GetList()
                .Where(e => e.FuelId == fuelID && e.DeletedAt == null)
                .ToList();

            return modelsByFuel;
        }

        public IList<Model> GetListByTransmission(int transmissionID)
        {
            IList<Model> modelsByTransmission = GetList()
                .Where(e => e.FuelId == transmissionID && e.DeletedAt == null)
                .ToList();

            return modelsByTransmission;
        }

        */

    }
}