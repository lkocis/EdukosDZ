using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća2_
{
    //Preimenovanje ZAD2
    class Product
    {
        public string Name { get; private set; }
        public string Price { get; private set; }
        public bool IsInStock { get; set; }

        public Product(string name, string price)
        {
            Name = name;
            Price = price;
            IsInStock = false;
        }
    }

    class ProductHandler
    {
        List<Product> products;

        public ProductHandler(List<Product> products)
        {
            this.products = products;
        }

        public void CheckIfAvailable(Product product)
        {
            foreach (Product p in products)
            {
                if (product == p)
                    p.IsInStock = true;
            }
        }
        public void RemoveAllUnavailable()
        {
            products.RemoveAll(product => product.IsInStock == false);
        }
    }
}
