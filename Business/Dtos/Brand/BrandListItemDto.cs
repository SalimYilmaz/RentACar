namespace Business.Dtos.Brand;

public class BrandListItemDto // Dto: Data Transfer Object
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public BrandListItemDto(int ıd, string? name)
    {
        Id = ıd;
        Name = name;
    }
}