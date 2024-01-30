namespace Core.DataAccess;

public interface IEntityRepository<TEntity, TEntityId> // Repository Design Pattern
{
    public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null); // ? Değerin opsiyonel olmasını sağlıyor. Zorunlu değil demek oluyor. Null olabilir.
    
    
    // Func fonksiyonları tutabileceğimiz bir type'dır.
    // Jenerik yapısında en son type argümanı fonksiyonun dönüş tipidir.
    // Ondan önce gelen type argümanları fonksiyonun sırasıyla parametre tipleridir.

    // Örnek kullanımlar:

    // Func<TEntity, bool> predicateFunc = (TEntity entity) => { return entity.Name == "Audi"; };

    // bool predicate(TEntity entity)
    // {
    //    bool result = entity.Name == "";
    //    return result;
    // }
    
    // Func<TEntity, bool> predicateFunc = predicate;

   
    public TEntity? Get(Func<TEntity, bool> predicate);  // Burası zorunlu, çünkü bir koşul almamız gerekiyor. bool>?  kullanılmadı o sebeple. Null olamaz.
    public TEntity Add(TEntity entity);
    public TEntity Update(TEntity entity);
    public TEntity Delete(TEntity entity, bool isSoftDelete = true);
}