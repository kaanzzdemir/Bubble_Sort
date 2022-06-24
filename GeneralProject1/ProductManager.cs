using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralProject1
{
    internal class ProductManager
    {
        List<Product> products = new List<Product>();
        public ProductManager()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Laptop",ProductPrice=1500,ProductStock=100},
                new Product{ProductId=2,ProductName="Mac",ProductPrice=4500,ProductStock=150},
                new Product{ProductId=3,ProductName="Telephone",ProductPrice=500,ProductStock=250},
                new Product{ProductId=4,ProductName="Fan",ProductPrice=80,ProductStock=1000},
                new Product{ProductId=5,ProductName="Mouse",ProductPrice=50,ProductStock=800}
            };
        }
        
        public List<Product> GetAll()
        {
            return products;
        }
        public List<Product> AddProduct(Product product)
        {
            products.Add(product);
            return products;
        }
    }
}
