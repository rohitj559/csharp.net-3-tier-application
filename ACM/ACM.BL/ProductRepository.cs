using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        // Retrieve one customer
        public Product Retrieve(int productId)
        {
            // Create the instance of product class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves defined customer

            // Temporary hard coded values to return 
            // a populated customer
            if (productId == 1)
            {
                product.ProductName = "SomeProduct";
                product.ProductDescription = "SomeDescription";
                product.CurrentPrice = 12;
            }
            return product;
        }

        // Save the current customer
        public bool Save(Product product)
        {
            // Code that saves passed in customer

            return true;
        }
    }
}
