﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {               
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public short ModelYear { get; set; }
        public string Plate { get; set; }
        
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }

       
        // Constructor
        public Car() 
        {

        }

        public Car(int colorId, int modelId, string carState, int kilometer, short modelYear, string plate, int brandId, int fuelId, int transmissionId)
        {                     
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;

            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
        }       
    }
}