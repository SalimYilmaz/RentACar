using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : InMemoryEntityRepositoryBase<Customer, int>, ICustomerDal
    {
        // InMemoryEntityRepositoryBase Class'ında generateId metodu abstract idi. Tanımlamamızı istedi. Tanımladık.
        protected override int generateId()
        {
            int nextId = Entities.Count == 0 ? 1 : Entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}
