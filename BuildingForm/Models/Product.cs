﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForm.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Catagory { get; set; }

        public decimal Price { get; set; }

        public bool IsAprowed { get; set; }

    }
}
