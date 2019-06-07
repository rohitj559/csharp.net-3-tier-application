using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }
         
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        // Validates the customer method
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        // Retrieve all customers
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        // Retrieve one customer
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        // Save the customer
        public bool Save()
        {
            return true;
        }
    }
}
