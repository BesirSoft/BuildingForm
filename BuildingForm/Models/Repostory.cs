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

                new Product(){Id=1, Name="product1", Description="mert", Price=10, IsAprowed=true  },
                new Product(){Id=2, Name="product2", Description="burak", Price=10, IsAprowed=false },
                new Product(){Id=3, Name="product3", Description="sli", Price=10, IsAprowed=true  },
                new Product(){Id=4, Name="product4", Description="sami", Price=10, IsAprowed=false },
                new Product(){Id=5, Name="product1", Description="t4besi", Price=10, IsAprowed=true  },
                new Product(){Id=6, Name="product2", Description="gaziduc", Price=10, IsAprowed=false },
                new Product(){Id=7, Name="product3", Description="veli", Price=10, IsAprowed=true  },
                new Product(){Id=8, Name="product4", Description="berilpr", Price=10, IsAprowed=false }




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
