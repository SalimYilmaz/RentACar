﻿namespace Business.Requests.Model
{
    public class GetModelListRequestByFuel
    {
        public int FuelId { get; set; }

        
        public GetModelListRequestByFuel(int fuelId)
        {
            FuelId = fuelId;
        }
    }
}