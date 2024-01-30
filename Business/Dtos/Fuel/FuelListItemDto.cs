namespace Business.Dtos.Fuel
{
    public class FuelListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FuelListItemDto(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}