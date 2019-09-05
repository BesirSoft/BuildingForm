using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForm.Models
{
    public static class Repostory
    {



        private static List<Product> _products;

        static Repostory()
        {
            _products = new List<Product>()
            {

                new Product(){Id=1, Name="product1", Description="", Price=10, IsAprowed=true},
                new Product(){Id=1, Name="product2", Description="", Price=10, IsAprowed=true},
                new Product(){Id=1, Name="product3", Description="", Price=10, IsAprowed=true},
                new Product(){Id=1, Name="product4", Description="", Price=10, IsAprowed=true}




            };



        }

       



        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product entity)
        {


            _products.Add(entity);
        }

    }
}
