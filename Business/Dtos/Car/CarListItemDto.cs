namespace Business.Dtos.Car
{
    public class CarListItemDto
    {
        public int Id { get; set; }       
        
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public short ModelYear { get; set; }
        public string Plate { get; set; }

        public CarListItemDto(int ıd, int colorId, int modelId, string carState, int kilometer, short modelYear, string plate)
        {
            Id = ıd;           
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }
    }
}