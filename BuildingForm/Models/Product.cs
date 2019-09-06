using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForm.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        public string Description { get; set; }
        public string Catagory { get; set; }
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        public bool IsAprowed { get; set; }

    }
}
