using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;
public interface IModelDal : IEntityRepository<Model, int>

{
    // CRUD Operations  -  Create, Read, Update, Delete
    
    // IEntityRepository<Model, int> kalıtımının örnek canlandırması:
   
    // public IList<Model> GetList();
    // public Model? GetById(int id);
    // public void Add(Model entity);
    // public void Update(Model entity);
    // public void Delete(Model entity);


    /*
     
    IList<Model> GetListByBrand(int brandId);
    IList<Model> GetListByFuel(int fuelId);
    IList<Model> GetListByTransmission(int transmissionId);

    */

}