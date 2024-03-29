﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : Entity<int>
    {

        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public bool Premium { get; set; }
        public double Rating { get; set; }


        // Constructor (Boş Constructor)
        public Brand()
        {

        }

        // Constructor (Dolu Constructor)
        public Brand(string name, string logoUrl, bool premium, double rating)
        {
            Name = name;
            LogoUrl = logoUrl;
            Premium = premium;
            Rating = rating;
        }

    }
}