using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Create the instance of customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves defined customer

            // Temporary hard coded values to return 
            // a populated customer
            if(customerId == 1)
            {
                customer.Email = "rohitj559@gmail.com";
                customer.LastName = "Jagannath";
                customer.FirstName = "Rohit";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        // Save the current customer
        public bool Save(Customer customer)
        {
            // Code that saves passed in customer

            return true;
        }
    }
}
