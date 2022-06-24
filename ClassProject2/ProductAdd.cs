using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject2
{
    internal class ProductAdd
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi : " + product.ProductName);
        }
    }
}
