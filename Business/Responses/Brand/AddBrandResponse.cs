namespace Business.Responses.Brand;

public class AddBrandResponse(int id, string name, DateTime createdAt)
{ // Dto
    public int Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public DateTime CreatedAt { get; set; } = createdAt;
}