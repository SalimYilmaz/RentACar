using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; } // Normalizasyon
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public short Year { get; set; }
    public decimal DailyPrice { get; set; }

    
    // Lazy Loading
    public Brand? Brand { get; set; } = null; // One to One ilişkisi
    public Fuel? Fuel { get; set; } = null; // One to One ilişkisi
    public Transmission? Transmission { get; set; }= null; // One to One ilişkisi
    public ICollection<Car>? Cars { get; set; } = null; // One to Many ilişkisi ( Model ile Car arasında )


    // ctor ile constructor eklenebilir. Constructor eklendi.
    public Model() 
    {

    }
    public Model( int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice)
    {
        
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
    }
}