namespace Business.Dtos.Transmission
{
    public class TransmissionListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TransmissionListItemDto(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}